using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;
using ATRGamers.ATRSeeder.Core.Annotations;
using ATRGamers.ATRSeeder.Core.Configuration;
using ATRGamers.ATRSeeder.Core.Context;
using ATRGamers.ATRSeeder.Core.Logging;
using ATRGamers.ATRSeeder.Core.Monitoring;
using ATRGamers.ATRSeeder.Core.ProcessControl;
using ATRGamers.ATRSeeder.Core.ServerManagement;
using ATRGamers.ATRSeeder.Core.Settings;
using ATRGamers.ATRSeeder.Forms.Extensions;
using ATRGamers.ATRSeeder.Forms.Properties;
using Timer = System.Windows.Forms.Timer;

namespace ATRGamers.ATRSeeder.Forms
{
    public partial class MainForm : Form
    {
        private readonly IDataContext _context;
        private readonly IProcessController _processController;
        private readonly ISeederActionFactory _seederActionFactory;
        //private readonly IdleKickAvoider _idleKickAvoider;
        private readonly ProcessMonitor _processMonitor;
        //private readonly ReadyUpper _readyUpper;
        private readonly Timer _serversRefreshTimer;
        private readonly Timer _browserRefreshTimer;
        private readonly Timer _statusRefreshTimer;
        private readonly Timer _randomSeedTimer;
        private Random _rand;
        private int _randMin = 60*1000;
        private int _randMax = 600*1000;
        private string _version;

        // CancellationTokens
        //private CancellationToken _avoidIdleKickCt;
        private CancellationToken _processMonitorCt;
        //private CancellationToken _readyUpdderCt;

        private MainForm()
        {
            InitializeComponent();
        }

        public MainForm(IDataContext context, [NotNull] IProcessController processController,
            [NotNull] ISeederActionFactory seederActionFactory) : this()
        {
            if (context == null) throw new ArgumentNullException("context");
            if (processController == null) throw new ArgumentNullException("processController");
            if (seederActionFactory == null) throw new ArgumentNullException("seederActionFactory");
            _context = context;
            _processController = processController;
            _seederActionFactory = seederActionFactory;

            _context.Session.PropertyChanged += ContextPropertyChanged;
            _context.Settings.PropertyChanged += ContextPropertyChanged;
            
            _browserRefreshTimer = new Timer();
            _statusRefreshTimer = new Timer();
            _serversRefreshTimer = new Timer();
            _rand = new Random();
            _randomSeedTimer = new Timer();

            _processMonitor = _processController.GetProcessMonitor();
            _processMonitor.OnProcessStateChanged += HandleProcessStatusChange;
            //_idleKickAvoider = _processController.GetIdleKickAvoider();
            //_readyUpper = _processController.GetReadyUpper();

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                _version = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            else
            {
                _version = "Debugging";
            }
        }

        #region Initialization

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CreateBindings();
            UiSetup();
            
            await RefreshServerStatusesNoSeed();
            

            geckoWebBrowser1.DocumentCompleted += BrowserChanged;

            FirstRunCheck();

            SetupRefreshTimers();

            // Spin up background processes
            SpinUpProcessMonitor();

            _context.ImportSettings("WEBCONFIG", _version);

            //await RefreshServerStatuses();
            updateSettings();

            await LoadBattlelog();

            Logger.Log("Finished initialization.");
        }

        private void UiSetup()
        {
            Icon = Resources.PB;
            notifyIcon1.Icon = Resources.PBOff;
            notifyIcon1.Text = Constants.ApplicationName;
            Text = Constants.ApplicationName;
            closeToolStripMenuItem.Text = String.Format("Close {0}", Constants.ApplicationName);
            SetCurrentSeedingStatusDisplay();
        }

        private async void SpinUpProcessMonitor()
        {
            _processMonitorCt = new CancellationTokenSource().Token;
            await _processMonitor.CheckOnProcess(_processMonitorCt, () => _context.Session.CurrentGame, SynchronizationContext.Current);
        }

        private void FirstRunCheck()
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                if (ApplicationDeployment.CurrentDeployment.IsFirstRun)
                {
                    ShowReleaseNotes();
                }
            }
        }

        private void SetupRefreshTimers()
        {
            SetBrowserRefreshTimer();
            SetStatusRefreshTimer();
            SetServerListRefreshTimer();
            SetRandomSeedTimer();
        }

        private void SetServerListRefreshTimer()
        {
            int serverListRefreshInterval = 300 * 1000;

            _serversRefreshTimer.Interval = serverListRefreshInterval;
            _serversRefreshTimer.Tick += TimedServerListRefresh;
            _serversRefreshTimer.Start();

        }

        private void SetBrowserRefreshTimer()
        {
            int refreshTimerInterval;
            if (!int.TryParse(refreshInterval.Text, out refreshTimerInterval))
                refreshTimerInterval = _context.Settings.RefreshInterval;

            refreshTimerInterval = refreshTimerInterval*1000;

            _browserRefreshTimer.Interval = refreshTimerInterval;

            _browserRefreshTimer.Tick += TimedRefresh;

            _browserRefreshTimer.Start();
        }

        private void SetStatusRefreshTimer()
        {
            int statusRefreshTimerInterval;
            if (!int.TryParse(statusRefreshInterval.Text, out statusRefreshTimerInterval))
                statusRefreshTimerInterval = _context.Settings.StatusRefreshInterval;

            statusRefreshTimerInterval = statusRefreshTimerInterval*1000;

            _statusRefreshTimer.Interval = statusRefreshTimerInterval;

            _statusRefreshTimer.Tick += TimedServerStatusRefresh;

            _statusRefreshTimer.Start();
        }

        private void SetRandomSeedTimer()
        {
            _randomSeedTimer.Tick += RandomSeedTimerHandler;
            
            var timerInterval = _rand.Next(_randMin, _randMax); // Random between 1 and 10 mins
            //SetStatus(String.Format("Time until next seed attempt: {0} seconds", (timerInterval / 1000).ToString()), 5);
            _randomSeedTimer.Interval = timerInterval;
            
        }

        

        private void CreateBindings()
        {
            username.DataBindings.Add("Text", _context.Settings, x => x.Username);
            password.DataBindings.Add("Text", _context.Settings, x => x.Password);
            email.DataBindings.Add("Text", _context.Settings, x => x.Email);

            currentLoggedInUser.DataBindings.Add("Text", _context.Session, x => x.CurrentLoggedInUser);
            //currentGameLabel.DataBindings.Add("Text", _context.Session, x => x.CurrentGameName);

            logging.DataBindings.Add("Checked", _context.Settings, x => x.EnableLogging, false,
                DataSourceUpdateMode.OnPropertyChanged);
            minimizeToTray.DataBindings.Add("Checked", _context.Settings, x => x.MinimizeToTray, false,
                DataSourceUpdateMode.OnPropertyChanged);
            gameBattlefieldFourEnabled.DataBindings.Add("Checked", _context.Settings, x => x.GameBattlefieldFourEnabled, false,
                DataSourceUpdateMode.OnPropertyChanged);
            gameBattlefieldHardlineEnabled.DataBindings.Add("Checked", _context.Settings, x => x.GameBattlefieldHardlineEnabled, false,
                DataSourceUpdateMode.OnPropertyChanged);
            autoLogin.DataBindings.Add("Checked", _context.Settings, x => x.AutoLogin, false,
                DataSourceUpdateMode.OnPropertyChanged);
            seedingEnabled.DataBindings.Add("Checked", _context.Session, x => x.SeedingEnabled);
            refreshInterval.DataBindings.Add("Text", _context.Settings, x => x.RefreshInterval);
            statusRefreshInterval.DataBindings.Add("Text", _context.Settings, x => x.StatusRefreshInterval);
            autoMinimizeSeeder.DataBindings.Add("Checked", _context.Settings, x => x.AutoMinimizeSeeder, false,
                DataSourceUpdateMode.OnPropertyChanged);
            //autoMinimizeGame.DataBindings.Add("Checked", _context.Settings, x => x.AutoMinimizeGame, false,
            //    DataSourceUpdateMode.OnPropertyChanged);

            saveSettings.DataBindings.Add("Enabled", _context.Settings, x => x.DirtySettings, true,
                DataSourceUpdateMode.OnPropertyChanged);

            var statusBindingSource = new BindingSource() {DataSource = _context.Session.ServerStatuses};
            dataGridView1.DataSource = statusBindingSource;

        }

        #endregion Intialization

        #region EventHandlers

        private void HandleProcessStatusChange(object sender, ProcessStateChangeEventArgs e)
        {
            _context.Session.BfIsRunning = e.IsRunning;

            if (_context.Session.BfIsRunning)
                notifyIcon1.Icon = Resources.PBOn;
            if (!_context.Session.BfIsRunning)
                notifyIcon1.Icon = Resources.PBOff;

            SetCurrentSeedingStatusDisplay();
        }

        private void SetCurrentSeedingStatusDisplay()
        {
            if (_context.Session.BfIsRunning)
            {
                currentSeedingStatus.ForeColor = Color.Green;
                currentSeedingStatus.Text = "Seeding";
            }
            else
            {
                currentSeedingStatus.ForeColor = Color.Red;
                currentSeedingStatus.Text = "Not Seeding";
            }
        }

        private async void TimedServerListRefresh(object sender, EventArgs e)
        {
            _context.ImportSettings("WEBCONFIG", _version);
            await RefreshServerStatuses();

        }

        private void TimedRefresh(object sender, EventArgs e)
        {
            AnyRefresh();
        }

        private async void TimedServerStatusRefresh(object sender, EventArgs e)
        {
            await RefreshServerStatuses();
        }

        private async void RandomSeedTimerHandler(object sender, EventArgs e)
        {
            // Set the next random tick length
            int timerInterval = _rand.Next(_randMin, _randMax);  // Get a new random interval between 1 and 10 mins
            //SetStatus(String.Format("Time until next seed attempt: {0} seconds", (timerInterval / 1000).ToString()), 5);
            _randomSeedTimer.Interval = timerInterval;

            
            await Seed();
        }

        private async Task RefreshServerStatusesNoSeed()
        {
            await _context.UpdateServerStatuses();
        }

        private async Task RefreshServerStatuses()
        {
            await _context.UpdateServerStatuses();
            //await Seed();  // Using random seeding timer for now RandomSeedTimerHandler(object, EventArgs)
        }

        private async Task Seed()
        {
            var seederAction = await _seederActionFactory.GetAction(_context);
            await SeederActionHandler(seederAction);
        }

        private async Task SeederActionHandler(SeederAction seederAction)
        {
            if (seederAction.ActionType == SeederActionType.Noop)
                return;
            if (seederAction.ActionType == SeederActionType.Stop)
            {
                await _processController.StopGame(_context);
                return;
            }
            if (seederAction.ActionType == SeederActionType.Seed)
            {
                await AttempSeeding(seederAction);
                return;
            }

            throw new ArgumentException("Unknow SeederAction ActionType.");
        }

        private void AnyRefresh()
        {
            DisableRefreshButton();
            RefreshPageAndData();
        }

        private void RefreshPageAndData()
        {
            _browserRefreshTimer.Stop();

            // Create a single use event handler to fire AttemptSeeding after context is updated
            // This is so that only refreshes triggerd by PS will fire Seeding. This will prevent changes
            // made inside the browser (by redirect/javascript/etc.) from firing the Seeding.
            ContextUpdatedHandler handler = null;
            handler = (tSender, tE) =>
            {
                _context.OnContextUpdate -= handler;
                //await RefreshServerStatuses();
            };
            _context.OnContextUpdate += handler;
            RefreshPage();

            _browserRefreshTimer.Start();
        }

        private Task<bool> CanSeed()
        {
            return Task<bool>.Factory.StartNew(() =>
            {
                var loggedIn = _context.Session.CurrentLoggedInUser != Constants.NotLoggedInUsername;
                if (!loggedIn)
                {
                    DialogResult result = MessageBoxEx.Show("User not logged in.", "Cannot Seed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 5000);
                }

                return loggedIn && _context.Session.SeedingEnabled;
            });
        }

        private async Task AttempSeeding(SeederAction seederAction)
        {
            if (!await CanSeed())
                return;

            _browserRefreshTimer.Stop();

            ContextUpdatedHandler handler = null;
            handler = (tSender, tE) =>
            {
                _context.OnContextUpdate -= handler;
                _context.Session.CurrentServer = seederAction.ServerStatus;

                //DialogResult result = MessageBoxEx.Show("Seeding in 5 seconds.", "Auto-Seeding", MessageBoxButtons.OKCancel,
                //    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 5000);
                
                //if (result == DialogResult.Cancel)
                //    return;

                JoinServer();
            };
            _context.OnContextUpdate += handler;

            UpdateGameType(seederAction.ServerStatus);

            await LoadPage(seederAction.ServerStatus.Address);

            _browserRefreshTimer.Start();
        }

        private void UpdateGameType(ServerStatus server)
        {
            string address = server.Address;

            GameInfo BF4 = Constants.Games.BF4;
            GameInfo BFH = Constants.Games.BFH;

            if (BF4.UrlMatch.IsMatch(address))
            {
                currentGameLabel.ForeColor = Color.Green;
                currentGameLabel.Text = BF4.GameName;
                _context.Session.CurrentGame = BF4;
            }
            else if (BFH.UrlMatch.IsMatch(address))
            {
                currentGameLabel.ForeColor = Color.Green;
                currentGameLabel.Text = BF4.GameName;
                _context.Session.CurrentGame = BFH;
            }
            else
            {
                currentGameLabel.ForeColor = Color.Red;
                currentGameLabel.Text = Constants.Games.Default.GameName;
                _context.Session.CurrentGame = Constants.Games.Default;
            }


        }


        /// <summary>
        /// This method is the event handler for any time the browser is refreshed
        /// </summary>
        private void BrowserChanged(object sender, EventArgs e)
        {
            curUrl.Text = geckoWebBrowser1.Url.ToString();
            UpdateContextWithBrowserData();
        }

        #endregion EventHandlers

        #region BattlelogManipulation

        private void JoinServer()
        {
            // Todo: This should be moved into configuration so it can more easily be changed
            const string jsCommand =
                "document.getElementsByClassName('btn btn-primary btn-large large arrow')[0].click()";

            RunJavascript(jsCommand);
            //_processController.MinimizeAfterLaunch();

            _context.JoinServer();
        }

        private async Task LoadBattlelog()
        {
            await LoadPage(Constants.DefaultUrl);
        }

        private async Task LoadPage(string url)
        {
            SetStatus(String.Format("Loading: {0}", url), 3);
            await Navigate(url);
        }

        private void RefreshPage()
        {
            geckoWebBrowser1.Refresh();
        }

        private Task Navigate(string url)
        {
            return Task.Factory.StartNew(() => BeginInvoke(new Action(() => geckoWebBrowser1.Navigate(url))));
        }

        private void ContextPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            UpdateInterface();
        }

        /// <summary>
        /// Update the context with the source from the page currently loaded in the browser
        /// </summary>
        private void UpdateContextWithBrowserData()
        {
            var source = string.Empty;
            var pageSource = string.Empty;

            // Get the source for the page currently loaded in the browser
            if (!string.IsNullOrEmpty(geckoWebBrowser1.Document.GetElementsByTagName("html")[0].InnerHtml))
                pageSource = geckoWebBrowser1.Document.GetElementsByTagName("html")[0].InnerHtml;

            source = pageSource;
            _context.UpdateContextWithBrowserPage(source);

            AutoLogin();
        }

        private void UpdateInterface()
        {
            currentLoggedInUser.ForeColor = _context.GetUserStatus() == UserStatus.Correct ? Color.Green : Color.Red;
        }

        private void AutoLogin()
        {
            if (!_context.Settings.AutoLogin)
                return;

            if (_context.GetUserStatus() == UserStatus.Correct)
                return;


            if (_context.GetUserStatus() == UserStatus.Incorrect)
            {
                return;
            }

            Login();
        }

        private async void Login()
        {
            SetStatus("Attempting login.");

            // Todo: This should be moved into configuration so it can more easily be changed
            string jsCommand =
                String.Format(
                    "$('#base-login-email').val('{0}');$('#base-login-password').val('{1}');$('#baseloginpersist').val() == '1';$(\"[name='submit']\").click();",
                    email.Text, password.Text);

            RunJavascript(jsCommand);

            await Sleep(1);
            SetStatus("");
        }

        private void RunJavascript(string javascript)
        {
            using (var context = new AutoJSContext(geckoWebBrowser1.Window.JSContext))
            {
                context.EvaluateScript(javascript);
            }
        }

        private void Logout()
        {
            geckoWebBrowser1.Navigate("http://battlelog.battlefield.com/bf4/session/logout/");
        }

        private Task CheckLogout(Action successfulLogout, Action failedLogout)
        {
            return Task.Factory.StartNew(() =>
            {
                const int logoutCheckCount = 10;
                for (int i = 0; i < logoutCheckCount; i++)
                {
                    if (_context.GetUserStatus() == UserStatus.None)
                    {
                        if (successfulLogout != null)
                            successfulLogout.Invoke();

                        return;
                    }

                    Thread.Sleep(1000);
                }
                if (failedLogout != null)
                    failedLogout.Invoke();
            });
        }

        #endregion BattlelogManipulation

        #region UiEvents

        private void saveSettings_Click(object sender, EventArgs e)
        {
            updateSettings();
        }

        private async void updateSettings()
        {
            _context.ImportSettings("WEBCONFIG", _version);
            await RefreshServerStatuses();
            _context.Settings.SaveSettings();
        }

        private void joinServerButton_Click(object sender, EventArgs e)
        {
            startSeeding();
        }

        private void stopSeedingButton_Click(object sender, EventArgs e)
        {
            stopSeeding();

        }

        private async void stopSeeding()
        {
            this.seedingEnabled.Checked = false;
            this.startSeedingButton.Enabled = true;
            this.stopSeedingButton.Enabled = false;
            _randomSeedTimer.Enabled = false;
            _randomSeedTimer.Stop();
            _context.Settings.SaveSettings();
            await _processController.StopGame(_context);
            await RefreshServerStatuses();
        }

        private async void startSeeding()
        {
            this.seedingEnabled.Checked = true;
            this.stopSeedingButton.Enabled = true;
            this.startSeedingButton.Enabled = false;
            _randomSeedTimer.Enabled = true;
            _randomSeedTimer.Start();
            _context.Settings.SaveSettings();
            await RefreshServerStatuses();
            await Seed();
        }

        private void geckoWebBrowser1_DomContentChanged(object sender, DomEventArgs e)
        {
            BrowserChanged(sender, e);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            AnyRefresh();
        }

        private void showWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void minimizeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState && _context.Settings.MinimizeToTray)
            {
                Hide();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSettingsDialog.ShowDialog();
        }

        private void saveSettingsDialog_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = saveSettingsDialog.FileName;
            _context.ExportSettings(fileName);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importSettingsDialog.ShowDialog();
        }

        private void importSettingsDialog_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = importSettingsDialog.FileName;
            _context.ImportSettings(fileName);
            AnyRefresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
            else
            {
                Hide();
                WindowState = FormWindowState.Minimized;
            }
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == false)
            {
                notifyIcon1.ShowBalloonTip(500, "ATRSeeder Still Running",
                    "Right click or double click to restore the window", ToolTipIcon.Info);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void viewReleaseNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutDialog().ShowDialog();
        }

        private async void statusRefresh_Click(object sender, EventArgs e)
        {
            await RefreshServerStatuses();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        #endregion UiEvents

        #region UiManipulation

        private async void DisableRefreshButton()
        {
            refresh.Enabled = false;
            await Sleep(5);
            refresh.Enabled = true;
        }


        private async void SetStatus(string status, int time = -1)
        {
            toolStripStatusLabel1.Text = status;
            statusStrip1.Refresh();

            if (time > -1)
            {
                await Sleep(time);
                SetStatus("");
            }
        }

        private static void ShowReleaseNotes()
        {
            new ReleaseNotes().ShowDialog();
        }

        #endregion UiManipulation

        private Task Sleep(int seconds)
        {
            return Task.Factory.StartNew(() => Thread.Sleep(seconds*1000));
        }

        private void currentLoggedInUser_TextChange(object sender, EventArgs e)
        {
            if (currentLoggedInUser.Text == Constants.NotLoggedInUsername || currentLoggedInUser.Text == "")
            {
                stopSeeding();
                startSeedingButton.Enabled = false;
                currentLoggedInUser.ForeColor = Color.Red;
            }
            else
            {
                startSeedingButton.Enabled = true;
                currentLoggedInUser.ForeColor = Color.Green;
            }
        }
    }
}
﻿namespace ATRGamers.ATRSeeder.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.webControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.browserPanel = new System.Windows.Forms.Panel();
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentLoggedInUser = new System.Windows.Forms.Label();
            this.saveSettings = new System.Windows.Forms.Button();
            this.seedingEnabled = new System.Windows.Forms.CheckBox();
            this.logging = new System.Windows.Forms.CheckBox();
            this.startSeedingButton = new System.Windows.Forms.Button();
            this.refreshInterval = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToTray = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReleaseNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsDialog = new System.Windows.Forms.SaveFileDialog();
            this.importSettingsDialog = new System.Windows.Forms.OpenFileDialog();
            this.autoLogin = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ServerSettingsTab = new System.Windows.Forms.TabPage();
            this.curUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserSettingsTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.AppSettingsTab = new System.Windows.Forms.TabPage();
            this.statusRefresh = new System.Windows.Forms.Button();
            this.statusRefreshInterval = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.autoMinimizeSeeder = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GameSettingsTab = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.gameBattlefieldHardlineEnabled = new System.Windows.Forms.CheckBox();
            this.gameBattlefieldFourEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentGameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.currentSeedingStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.StatusTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ServerNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerMaxCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentPlayersCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinPlayersCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPlayersCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrowserTab = new System.Windows.Forms.TabPage();
            this.stopSeedingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webControlBindingSource)).BeginInit();
            this.browserPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ServerSettingsTab.SuspendLayout();
            this.UserSettingsTab.SuspendLayout();
            this.AppSettingsTab.SuspendLayout();
            this.GameSettingsTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.StatusTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BrowserTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // browserPanel
            // 
            this.browserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserPanel.Controls.Add(this.geckoWebBrowser1);
            this.browserPanel.Location = new System.Drawing.Point(3, 3);
            this.browserPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 80);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(1090, 480);
            this.browserPanel.TabIndex = 3;
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geckoWebBrowser1.Location = new System.Drawing.Point(3, 3);
            this.geckoWebBrowser1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(1090, 480);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            this.geckoWebBrowser1.DomContentChanged += new System.EventHandler<Gecko.DomEventArgs>(this.geckoWebBrowser1_DomContentChanged);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(104, 9);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(144, 20);
            this.username.TabIndex = 9;
            this.username.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Current User:";
            // 
            // currentLoggedInUser
            // 
            this.currentLoggedInUser.AutoSize = true;
            this.currentLoggedInUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLoggedInUser.ForeColor = System.Drawing.Color.Red;
            this.currentLoggedInUser.Location = new System.Drawing.Point(146, 16);
            this.currentLoggedInUser.Name = "currentLoggedInUser";
            this.currentLoggedInUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.currentLoggedInUser.Size = new System.Drawing.Size(110, 20);
            this.currentLoggedInUser.TabIndex = 15;
            this.currentLoggedInUser.Text = "Not Logged In";
            this.currentLoggedInUser.TextChanged += new System.EventHandler(this.currentLoggedInUser_TextChange);
            // 
            // saveSettings
            // 
            this.saveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSettings.Location = new System.Drawing.Point(980, 26);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(134, 23);
            this.saveSettings.TabIndex = 20;
            this.saveSettings.Text = "Save Settings";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // seedingEnabled
            // 
            this.seedingEnabled.AutoSize = true;
            this.seedingEnabled.Enabled = false;
            this.seedingEnabled.Location = new System.Drawing.Point(8, 90);
            this.seedingEnabled.Name = "seedingEnabled";
            this.seedingEnabled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.seedingEnabled.Size = new System.Drawing.Size(107, 17);
            this.seedingEnabled.TabIndex = 23;
            this.seedingEnabled.Text = "Seeding Enabled";
            this.seedingEnabled.UseVisualStyleBackColor = true;
            // 
            // logging
            // 
            this.logging.AutoSize = true;
            this.logging.Enabled = false;
            this.logging.Location = new System.Drawing.Point(55, 83);
            this.logging.Name = "logging";
            this.logging.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logging.Size = new System.Drawing.Size(64, 17);
            this.logging.TabIndex = 22;
            this.logging.Text = "Logging";
            this.logging.UseVisualStyleBackColor = true;
            this.logging.Visible = false;
            // 
            // startSeedingButton
            // 
            this.startSeedingButton.Enabled = false;
            this.startSeedingButton.Location = new System.Drawing.Point(15, 141);
            this.startSeedingButton.Name = "startSeedingButton";
            this.startSeedingButton.Size = new System.Drawing.Size(210, 23);
            this.startSeedingButton.TabIndex = 24;
            this.startSeedingButton.Text = "Start Seeding";
            this.startSeedingButton.UseVisualStyleBackColor = true;
            this.startSeedingButton.Click += new System.EventHandler(this.joinServerButton_Click);
            // 
            // refreshInterval
            // 
            this.refreshInterval.Enabled = false;
            this.refreshInterval.Location = new System.Drawing.Point(155, 9);
            this.refreshInterval.Name = "refreshInterval";
            this.refreshInterval.Size = new System.Drawing.Size(43, 20);
            this.refreshInterval.TabIndex = 25;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(214, 7);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(87, 23);
            this.refresh.TabIndex = 27;
            this.refresh.Text = "Refresh Now";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showWindowToolStripMenuItem,
            this.minimizeWindowToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 76);
            // 
            // showWindowToolStripMenuItem
            // 
            this.showWindowToolStripMenuItem.Name = "showWindowToolStripMenuItem";
            this.showWindowToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.showWindowToolStripMenuItem.Text = "Show Window";
            this.showWindowToolStripMenuItem.Click += new System.EventHandler(this.showWindowToolStripMenuItem_Click);
            // 
            // minimizeWindowToolStripMenuItem
            // 
            this.minimizeWindowToolStripMenuItem.Name = "minimizeWindowToolStripMenuItem";
            this.minimizeWindowToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.minimizeWindowToolStripMenuItem.Text = "Minimize Window";
            this.minimizeWindowToolStripMenuItem.Click += new System.EventHandler(this.minimizeWindowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // minimizeToTray
            // 
            this.minimizeToTray.AutoSize = true;
            this.minimizeToTray.Location = new System.Drawing.Point(13, 62);
            this.minimizeToTray.Name = "minimizeToTray";
            this.minimizeToTray.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.minimizeToTray.Size = new System.Drawing.Size(106, 17);
            this.minimizeToTray.TabIndex = 28;
            this.minimizeToTray.Text = "Minimize To Tray";
            this.minimizeToTray.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(104, 62);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(144, 20);
            this.password.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Password";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReleaseNotesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewReleaseNotesToolStripMenuItem
            // 
            this.viewReleaseNotesToolStripMenuItem.Name = "viewReleaseNotesToolStripMenuItem";
            this.viewReleaseNotesToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.viewReleaseNotesToolStripMenuItem.Text = "About";
            this.viewReleaseNotesToolStripMenuItem.Click += new System.EventHandler(this.viewReleaseNotesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // autoLogin
            // 
            this.autoLogin.AutoSize = true;
            this.autoLogin.Location = new System.Drawing.Point(6, 90);
            this.autoLogin.Name = "autoLogin";
            this.autoLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.autoLogin.Size = new System.Drawing.Size(77, 17);
            this.autoLogin.TabIndex = 32;
            this.autoLogin.Text = "Auto Login";
            this.autoLogin.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1126, 22);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "SomeShit";
            // 
            // toolStrip
            // 
            this.toolStrip.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel1.Text = "ATRSeeder";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(104, 86);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 34;
            this.loginButton.Text = "Login Now";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.ServerSettingsTab);
            this.tabControl1.Controls.Add(this.UserSettingsTab);
            this.tabControl1.Controls.Add(this.AppSettingsTab);
            this.tabControl1.Controls.Add(this.GameSettingsTab);
            this.tabControl1.Location = new System.Drawing.Point(725, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 139);
            this.tabControl1.TabIndex = 35;
            // 
            // ServerSettingsTab
            // 
            this.ServerSettingsTab.Controls.Add(this.curUrl);
            this.ServerSettingsTab.Controls.Add(this.label4);
            this.ServerSettingsTab.Controls.Add(this.seedingEnabled);
            this.ServerSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.ServerSettingsTab.Name = "ServerSettingsTab";
            this.ServerSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServerSettingsTab.Size = new System.Drawing.Size(382, 113);
            this.ServerSettingsTab.TabIndex = 0;
            this.ServerSettingsTab.Text = "Main";
            this.ServerSettingsTab.UseVisualStyleBackColor = true;
            // 
            // curUrl
            // 
            this.curUrl.Location = new System.Drawing.Point(6, 19);
            this.curUrl.Name = "curUrl";
            this.curUrl.ReadOnly = true;
            this.curUrl.Size = new System.Drawing.Size(370, 20);
            this.curUrl.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Current URL";
            // 
            // UserSettingsTab
            // 
            this.UserSettingsTab.Controls.Add(this.label10);
            this.UserSettingsTab.Controls.Add(this.email);
            this.UserSettingsTab.Controls.Add(this.loginButton);
            this.UserSettingsTab.Controls.Add(this.username);
            this.UserSettingsTab.Controls.Add(this.label3);
            this.UserSettingsTab.Controls.Add(this.autoLogin);
            this.UserSettingsTab.Controls.Add(this.label9);
            this.UserSettingsTab.Controls.Add(this.password);
            this.UserSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.UserSettingsTab.Name = "UserSettingsTab";
            this.UserSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserSettingsTab.Size = new System.Drawing.Size(382, 113);
            this.UserSettingsTab.TabIndex = 1;
            this.UserSettingsTab.Text = "User";
            this.UserSettingsTab.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(104, 36);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(144, 20);
            this.email.TabIndex = 11;
            // 
            // AppSettingsTab
            // 
            this.AppSettingsTab.Controls.Add(this.statusRefresh);
            this.AppSettingsTab.Controls.Add(this.statusRefreshInterval);
            this.AppSettingsTab.Controls.Add(this.label8);
            this.AppSettingsTab.Controls.Add(this.autoMinimizeSeeder);
            this.AppSettingsTab.Controls.Add(this.label11);
            this.AppSettingsTab.Controls.Add(this.refreshInterval);
            this.AppSettingsTab.Controls.Add(this.minimizeToTray);
            this.AppSettingsTab.Controls.Add(this.logging);
            this.AppSettingsTab.Controls.Add(this.refresh);
            this.AppSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.AppSettingsTab.Name = "AppSettingsTab";
            this.AppSettingsTab.Size = new System.Drawing.Size(382, 113);
            this.AppSettingsTab.TabIndex = 2;
            this.AppSettingsTab.Text = "Application";
            this.AppSettingsTab.UseVisualStyleBackColor = true;
            // 
            // statusRefresh
            // 
            this.statusRefresh.Location = new System.Drawing.Point(214, 32);
            this.statusRefresh.Name = "statusRefresh";
            this.statusRefresh.Size = new System.Drawing.Size(87, 23);
            this.statusRefresh.TabIndex = 33;
            this.statusRefresh.Text = "Refresh Now";
            this.statusRefresh.UseVisualStyleBackColor = true;
            this.statusRefresh.Click += new System.EventHandler(this.statusRefresh_Click);
            // 
            // statusRefreshInterval
            // 
            this.statusRefreshInterval.Enabled = false;
            this.statusRefreshInterval.Location = new System.Drawing.Point(155, 34);
            this.statusRefreshInterval.Name = "statusRefreshInterval";
            this.statusRefreshInterval.Size = new System.Drawing.Size(43, 20);
            this.statusRefreshInterval.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Status Refresh (Seconds):";
            // 
            // autoMinimizeSeeder
            // 
            this.autoMinimizeSeeder.AutoSize = true;
            this.autoMinimizeSeeder.Location = new System.Drawing.Point(137, 62);
            this.autoMinimizeSeeder.Name = "autoMinimizeSeeder";
            this.autoMinimizeSeeder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.autoMinimizeSeeder.Size = new System.Drawing.Size(128, 17);
            this.autoMinimizeSeeder.TabIndex = 29;
            this.autoMinimizeSeeder.Text = "Auto-Minimize Seeder";
            this.autoMinimizeSeeder.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Browser Refresh (Seconds):";
            // 
            // GameSettingsTab
            // 
            this.GameSettingsTab.Controls.Add(this.label12);
            this.GameSettingsTab.Controls.Add(this.gameBattlefieldHardlineEnabled);
            this.GameSettingsTab.Controls.Add(this.gameBattlefieldFourEnabled);
            this.GameSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.GameSettingsTab.Name = "GameSettingsTab";
            this.GameSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.GameSettingsTab.Size = new System.Drawing.Size(382, 113);
            this.GameSettingsTab.TabIndex = 3;
            this.GameSettingsTab.Text = "Games";
            this.GameSettingsTab.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(227, 26);
            this.label12.TabIndex = 2;
            this.label12.Text = "Select the games that you have *INSTALLED*\r\nThen click \"Save Settings\" above.";
            // 
            // gameBattlefieldHardlineEnabled
            // 
            this.gameBattlefieldHardlineEnabled.AutoSize = true;
            this.gameBattlefieldHardlineEnabled.Location = new System.Drawing.Point(9, 49);
            this.gameBattlefieldHardlineEnabled.Name = "gameBattlefieldHardlineEnabled";
            this.gameBattlefieldHardlineEnabled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gameBattlefieldHardlineEnabled.Size = new System.Drawing.Size(114, 17);
            this.gameBattlefieldHardlineEnabled.TabIndex = 1;
            this.gameBattlefieldHardlineEnabled.Text = "Battlefield Hardline";
            this.gameBattlefieldHardlineEnabled.UseVisualStyleBackColor = true;
            // 
            // gameBattlefieldFourEnabled
            // 
            this.gameBattlefieldFourEnabled.AutoSize = true;
            this.gameBattlefieldFourEnabled.Location = new System.Drawing.Point(42, 72);
            this.gameBattlefieldFourEnabled.Name = "gameBattlefieldFourEnabled";
            this.gameBattlefieldFourEnabled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gameBattlefieldFourEnabled.Size = new System.Drawing.Size(81, 17);
            this.gameBattlefieldFourEnabled.TabIndex = 0;
            this.gameBattlefieldFourEnabled.Text = "Battlefield 4";
            this.gameBattlefieldFourEnabled.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentGameLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.currentSeedingStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.currentLoggedInUser);
            this.groupBox1.Location = new System.Drawing.Point(15, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 110);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // currentGameLabel
            // 
            this.currentGameLabel.AutoSize = true;
            this.currentGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentGameLabel.ForeColor = System.Drawing.Color.Red;
            this.currentGameLabel.Location = new System.Drawing.Point(146, 59);
            this.currentGameLabel.Name = "currentGameLabel";
            this.currentGameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.currentGameLabel.Size = new System.Drawing.Size(47, 20);
            this.currentGameLabel.TabIndex = 39;
            this.currentGameLabel.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Current Game:";
            // 
            // currentSeedingStatus
            // 
            this.currentSeedingStatus.AutoSize = true;
            this.currentSeedingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSeedingStatus.ForeColor = System.Drawing.Color.Red;
            this.currentSeedingStatus.Location = new System.Drawing.Point(146, 36);
            this.currentSeedingStatus.Name = "currentSeedingStatus";
            this.currentSeedingStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.currentSeedingStatus.Size = new System.Drawing.Size(97, 20);
            this.currentSeedingStatus.TabIndex = 37;
            this.currentSeedingStatus.Text = "Not Seeding";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Seeding Status:";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.StatusTab);
            this.tabControl2.Controls.Add(this.BrowserTab);
            this.tabControl2.Location = new System.Drawing.Point(12, 174);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1103, 506);
            this.tabControl2.TabIndex = 0;
            // 
            // StatusTab
            // 
            this.StatusTab.Controls.Add(this.panel1);
            this.StatusTab.Location = new System.Drawing.Point(4, 22);
            this.StatusTab.Name = "StatusTab";
            this.StatusTab.Size = new System.Drawing.Size(1095, 480);
            this.StatusTab.TabIndex = 0;
            this.StatusTab.Text = "Status";
            this.StatusTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 480);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServerNameCol,
            this.AddressCol,
            this.ServerMaxCol,
            this.CurrentPlayersCol,
            this.MinPlayersCol,
            this.MaxPlayersCol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 480);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ServerNameCol
            // 
            this.ServerNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServerNameCol.DataPropertyName = "Name";
            this.ServerNameCol.HeaderText = "Server Name";
            this.ServerNameCol.Name = "ServerNameCol";
            this.ServerNameCol.ReadOnly = true;
            // 
            // AddressCol
            // 
            this.AddressCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AddressCol.DataPropertyName = "Address";
            this.AddressCol.HeaderText = "Address";
            this.AddressCol.Name = "AddressCol";
            this.AddressCol.ReadOnly = true;
            this.AddressCol.Width = 70;
            // 
            // ServerMaxCol
            // 
            this.ServerMaxCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ServerMaxCol.DataPropertyName = "ServerMax";
            this.ServerMaxCol.HeaderText = "Slots";
            this.ServerMaxCol.Name = "ServerMaxCol";
            this.ServerMaxCol.ReadOnly = true;
            this.ServerMaxCol.Width = 55;
            // 
            // CurrentPlayersCol
            // 
            this.CurrentPlayersCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CurrentPlayersCol.DataPropertyName = "CurPlayers";
            this.CurrentPlayersCol.HeaderText = "Current";
            this.CurrentPlayersCol.Name = "CurrentPlayersCol";
            this.CurrentPlayersCol.ReadOnly = true;
            this.CurrentPlayersCol.Width = 66;
            // 
            // MinPlayersCol
            // 
            this.MinPlayersCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MinPlayersCol.DataPropertyName = "MinPlayers";
            this.MinPlayersCol.HeaderText = "Start";
            this.MinPlayersCol.Name = "MinPlayersCol";
            this.MinPlayersCol.ReadOnly = true;
            this.MinPlayersCol.Width = 54;
            // 
            // MaxPlayersCol
            // 
            this.MaxPlayersCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaxPlayersCol.DataPropertyName = "MaxPlayers";
            this.MaxPlayersCol.HeaderText = "Stop";
            this.MaxPlayersCol.Name = "MaxPlayersCol";
            this.MaxPlayersCol.ReadOnly = true;
            this.MaxPlayersCol.Width = 54;
            // 
            // BrowserTab
            // 
            this.BrowserTab.Controls.Add(this.browserPanel);
            this.BrowserTab.Location = new System.Drawing.Point(4, 22);
            this.BrowserTab.Name = "BrowserTab";
            this.BrowserTab.Size = new System.Drawing.Size(1095, 480);
            this.BrowserTab.TabIndex = 0;
            this.BrowserTab.Text = "Browser";
            this.BrowserTab.UseVisualStyleBackColor = true;
            // 
            // stopSeedingButton
            // 
            this.stopSeedingButton.Enabled = false;
            this.stopSeedingButton.Location = new System.Drawing.Point(225, 141);
            this.stopSeedingButton.Name = "stopSeedingButton";
            this.stopSeedingButton.Size = new System.Drawing.Size(210, 23);
            this.stopSeedingButton.TabIndex = 37;
            this.stopSeedingButton.Text = "Stop Seeding";
            this.stopSeedingButton.UseVisualStyleBackColor = true;
            this.stopSeedingButton.Click += new System.EventHandler(this.stopSeedingButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 705);
            this.Controls.Add(this.stopSeedingButton);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.startSeedingButton);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1142, 733);
            this.Name = "MainForm";
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.webControlBindingSource)).EndInit();
            this.browserPanel.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ServerSettingsTab.ResumeLayout(false);
            this.ServerSettingsTab.PerformLayout();
            this.UserSettingsTab.ResumeLayout(false);
            this.UserSettingsTab.PerformLayout();
            this.AppSettingsTab.ResumeLayout(false);
            this.AppSettingsTab.PerformLayout();
            this.GameSettingsTab.ResumeLayout(false);
            this.GameSettingsTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.StatusTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BrowserTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource webControlBindingSource;
        private System.Windows.Forms.Panel browserPanel;
        private Gecko.GeckoWebBrowser geckoWebBrowser1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentLoggedInUser;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.CheckBox seedingEnabled;
        private System.Windows.Forms.CheckBox logging;
        private System.Windows.Forms.Button startSeedingButton;
        private System.Windows.Forms.TextBox refreshInterval;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox minimizeToTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeWindowToolStripMenuItem;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveSettingsDialog;
        private System.Windows.Forms.OpenFileDialog importSettingsDialog;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox autoLogin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ServerSettingsTab;
        private System.Windows.Forms.TabPage UserSettingsTab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TabPage AppSettingsTab;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox autoMinimizeSeeder;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReleaseNotesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage BrowserTab;
        private System.Windows.Forms.TabPage StatusTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button statusRefresh;
        private System.Windows.Forms.TextBox statusRefreshInterval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox curUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label currentSeedingStatus;
        private System.Windows.Forms.Label currentGameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage GameSettingsTab;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox gameBattlefieldHardlineEnabled;
        private System.Windows.Forms.CheckBox gameBattlefieldFourEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerMaxCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentPlayersCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinPlayersCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPlayersCol;
        private System.Windows.Forms.Button stopSeedingButton;
    }
}


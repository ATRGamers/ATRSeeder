using System.Collections.Generic;
using ATRGamers.ATRSeeder.Core.Configuration;
using ATRGamers.ATRSeeder.Core.Settings;
using System.Text.RegularExpressions;

namespace ATRGamers.ATRSeeder.Core.Context
{
    public class SessionData : BindableBase
    {
        public SessionData()
        {
            _serverStatuses = new ServerStatusCollection();
        }
        
        private bool _seedingEnabled = true;
        private string _currentLoggedInUser;
        private GameInfo _currentGame = Constants.Games.Default;
        private bool _bfIsRunning;
        private ServerStatusCollection _serverStatuses;
        private ServerStatus _currentServer;

        public bool SeedingEnabled
        {
            get { return this._seedingEnabled; }
            set { SetField(ref this._seedingEnabled, value); }
        }

        public string CurrentLoggedInUser
        {
            get { return this._currentLoggedInUser; }
            set { SetField(ref _currentLoggedInUser, value); }
        }

        public string CurrentGameProcessName
        {
            get { return this._currentGame.ProcessName; }
        }

        public string CurrentGameName
        {
            get { return this._currentGame.GameName; }
        }

        public Regex CurrentGameUrlMatch
        {
            get { return this._currentGame.UrlMatch; }
        }

        public string CurrentGameFaultWindowTitle
        {
            get { return this._currentGame.FaultWindowTitle; }
        }

        public string CurrentGameWindowTitle
        {
            get { return this._currentGame.WindowTitle; }
        }

        // Deprecated
//        public GameInfo CurrentGame
//        {
//            // Note: Right now we only support BF4
//            get { return this._currentGame; }
//            set { /*SetField(ref _currentGame, value);*/ }
//        }

        public bool BfIsRunning
        {
            get { return this._bfIsRunning; }
            set { SetField(ref _bfIsRunning, value); }
        }

        public ServerStatusCollection ServerStatuses { get { return _serverStatuses; }}

        public ServerStatus CurrentServer
        {
            get { return this._currentServer; }
            set { SetField(ref _currentServer, value); }
        }
    }
}
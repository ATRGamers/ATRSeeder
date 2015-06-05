﻿using System;
using System.ComponentModel;
using Newtonsoft.Json;
using ATRGamers.ATRSeeder.Core.Settings;

namespace ATRGamers.ATRSeeder.Core.Context
{
    public class BindableSettings : BindableBase
    {
        private readonly SeederUserSettings _settings;

        public BindableSettings(SeederUserSettings settings)
        {
            if (settings == null) throw new ArgumentNullException("settings");
            //settings.Reset();
            //settings.Reload();
            //settings.Upgrade();
            //settings.Save();
            _settings = settings;
            DirtySettings = false;
            this.PropertyChanged += SettingChanged;
            Servers.ServerChanged += SettingChanged;
        }

        // Note: This is to allow Deserializing to this class
        protected BindableSettings() : this(new SeederUserSettings())
        {
        }

        private void SettingChanged(object sender, EventArgs e)
        {
            var propertyChangedEventArgs = e as PropertyChangedEventArgs;
            if (propertyChangedEventArgs != null)
            {
                if (propertyChangedEventArgs.PropertyName == "DirtySettings")
                    return;
            }

            //_settings.Save();
            DirtySettings = true;
        }

        public bool SaveSettings()
        {
            _settings.Save();
            DirtySettings = false;
            return true;
        }

        private bool _dirtySettings;
        [JsonIgnore]
        public bool DirtySettings
        {
            get { return _dirtySettings; }
            set { SetField(ref _dirtySettings, value); }
        }

        [JsonIgnore]
        public string Username
        {
            get { return _settings.Username; }
            set { SetProperty(_settings, value, x => x.Username); }
        }

        public bool EnableLogging
        {
            get { return _settings.EnableLogging; }
            set { SetProperty(_settings, value, x => x.EnableLogging); }
        }

        public Servers Servers
        {
            get { return _settings.Servers; }
            set { SetProperty(_settings, value, x => x.Servers); }
        }

        // Deprecated
//        [JsonIgnore]
//        public int CurrentServer
//        {
//            get { return _settings.CurrentServer; }
//            set { SetProperty(_settings, value, x => x.CurrentServer); }
//        }

        public int RefreshInterval
        {
            get { return _settings.RefreshInterval; }
            set { SetProperty(_settings, value, x => x.RefreshInterval); }
        }

        public int StatusRefreshInterval
        {
            get { return _settings.StatusRefreshInterval; }
            set { SetProperty(_settings, value, x => x.StatusRefreshInterval); }
        }

        public int ServerListRefreshInterval
        {
            get { return _settings.ServerListRefreshInterval; }
            set { SetProperty(_settings, value, x => x.ServerListRefreshInterval); }
        }

        [JsonIgnore]
        public bool MinimizeToTray
        {
            get { return _settings.MinimizeToTray; }
            set { SetProperty(_settings, value, x => x.MinimizeToTray); }
        }

        public bool AutoLogin
        {
            get { return _settings.AutoLogin; }
            set { SetProperty(_settings, value, x => x.AutoLogin); }
        }

        [JsonIgnore]
        public string Password
        {
            get { return _settings.Password; }
            set { SetProperty(_settings, value, x => x.Password); }
        }

        [JsonIgnore]
        public string Email
        {
            get { return _settings.Email; }
            set { SetProperty(_settings, value, x => x.Email); }
        }

        [JsonIgnore]
        public bool AutoMinimizeSeeder
        {
            get { return _settings.AutoMinimizeSeeder; }
            set { SetProperty(_settings, value, x => x.AutoMinimizeSeeder); }
        }

        [JsonIgnore]
        public bool GameBattlefieldFourEnabled
        {
            get { return _settings.GameBattlefieldFourEnabled; }
            set { SetProperty(_settings, value, x => x.GameBattlefieldFourEnabled); }
        }

        [JsonIgnore]
        public bool GameBattlefieldHardlineEnabled
        {
            get { return _settings.GameBattlefieldHardlineEnabled; }
            set { SetProperty(_settings, value, x => x.GameBattlefieldHardlineEnabled); }
        }
    }
}
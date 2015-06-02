using System;
using System.Collections.Generic;
using ATRGamers.ATRSeeder.Core.Context;
using ATRGamers.ATRSeeder.Core.Initialization;
using ATRGamers.ATRSeeder.Core.ProcessControl;
using ATRGamers.ATRSeeder.Core.ServerManagement;
using ATRGamers.ATRSeeder.Core.Settings;

namespace ATRGamers.ATRSeeder.Forms.Initalization
{
    public static class Bootstrapper
    {
        public static MainForm GetMainForm(IDataContext dataContext)
        {
            return new MainForm(dataContext,
                new ProcessController(),
                new SeederActionFactory());
        }

        public static IDataContext GetDataContext()
        {
            return new SeederContext(
                    new SessionData(),
                    new BindableSettings(
                        new SeederUserSettings()),
                    new List<IDataContextUpdater>
                        {
                            new CurrentBf4UserUpdater(),
                        }.ToArray(),
                    new ServerStatusUpdater(
                        new UpdateServerIds()),
                    new PlayerStatusGetter());
        }
    }
}
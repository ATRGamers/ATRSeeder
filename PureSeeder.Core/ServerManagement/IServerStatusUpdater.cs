using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ATRGamers.ATRSeeder.Core.Context;

namespace ATRGamers.ATRSeeder.Core.ServerManagement
{
    public interface IServerStatusUpdater
    {
        Task UpdateServerStatuses(IDataContext context);
    }
}
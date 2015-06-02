using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ATRGamers.ATRSeeder.Core.Configuration;
using ATRGamers.ATRSeeder.Core.Monitoring;
using ATRGamers.ATRSeeder.Core.Context;

namespace ATRGamers.ATRSeeder.Core.ProcessControl
{
    public interface IProcessController
    {
        Task StopGame(IDataContext context);
        //Task MinimizeAfterLaunch();
        //Task<bool> BfIsRunning();

        ProcessMonitor GetProcessMonitor();
        IdleKickAvoider GetIdleKickAvoider();
        ReadyUpper GetReadyUpper();
    }

    class ProcessController : IProcessController
    {
        public async Task StopGame(IDataContext context)
        {
            if (!context.IsSeeding())
                return;

            var process = Process.GetProcessesByName(context.Session.CurrentGame.ProcessName).FirstOrDefault();

            if (process != null)
                process.Kill();
        }

//        public Task<bool> BfIsRunning()
//        {
//            throw new System.NotImplementedException();
//        }

        public ProcessMonitor GetProcessMonitor()
        {
            return new ProcessMonitor(
                new ICrashDetector[]
                {
                    new CrashDetector(new CrashHandler()), new DetectCrashByFaultWindow(), 
                });
        }

        public IdleKickAvoider GetIdleKickAvoider()
        {
            return new IdleKickAvoider();
        }

        public ReadyUpper GetReadyUpper()
        {
            return new ReadyUpper();
        }
    }
}
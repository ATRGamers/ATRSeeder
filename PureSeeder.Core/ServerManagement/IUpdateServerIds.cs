using System.Threading.Tasks;
using ATRGamers.ATRSeeder.Core.Context;

namespace ATRGamers.ATRSeeder.Core.ServerManagement
{
    public interface IUpdateServerIds
    {
        Task Update(IDataContext context, bool updateAll = false);
    }
}
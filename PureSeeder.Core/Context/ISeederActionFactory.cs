using System.Threading.Tasks;

namespace ATRGamers.ATRSeeder.Core.Context
{
    public interface ISeederActionFactory
    {
        Task<SeederAction> GetAction(IDataContext context);
    }
}
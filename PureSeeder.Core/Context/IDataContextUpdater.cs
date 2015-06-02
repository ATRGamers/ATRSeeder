namespace ATRGamers.ATRSeeder.Core.Context
{
    public interface IDataContextUpdater
    {
        void Update(IDataContext context, string pageData);
    }
}
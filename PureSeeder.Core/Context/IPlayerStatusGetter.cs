namespace ATRGamers.ATRSeeder.Core.Context
{
    public interface IPlayerStatusGetter
    {
        PlayerStatus GetPlayerStatus(IDataContext context);
    }
}
namespace ATRGamers.ATRSeeder.Core.Initialization
{
    public interface IContainer
    {
        T Resolve<T>();
    }
}
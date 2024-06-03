using Volo.Abp.Modularity;

namespace Other.Thread;

public abstract class ThreadApplicationTestBase<TStartupModule> : ThreadTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

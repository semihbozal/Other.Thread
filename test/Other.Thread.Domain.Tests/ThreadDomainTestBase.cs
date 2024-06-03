using Volo.Abp.Modularity;

namespace Other.Thread;

/* Inherit from this class for your domain layer tests. */
public abstract class ThreadDomainTestBase<TStartupModule> : ThreadTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

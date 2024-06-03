using Volo.Abp.Modularity;

namespace Other.Thread;

[DependsOn(
    typeof(ThreadDomainModule),
    typeof(ThreadTestBaseModule)
)]
public class ThreadDomainTestModule : AbpModule
{

}

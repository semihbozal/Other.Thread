using Volo.Abp.Modularity;

namespace Other.Thread;

[DependsOn(
    typeof(ThreadApplicationModule),
    typeof(ThreadDomainTestModule)
)]
public class ThreadApplicationTestModule : AbpModule
{

}

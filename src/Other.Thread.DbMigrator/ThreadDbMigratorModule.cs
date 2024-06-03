using Other.Thread.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Other.Thread.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ThreadEntityFrameworkCoreModule),
    typeof(ThreadApplicationContractsModule)
    )]
public class ThreadDbMigratorModule : AbpModule
{
}

using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Other.Thread.Data;

/* This is used if database provider does't define
 * IThreadDbSchemaMigrator implementation.
 */
public class NullThreadDbSchemaMigrator : IThreadDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

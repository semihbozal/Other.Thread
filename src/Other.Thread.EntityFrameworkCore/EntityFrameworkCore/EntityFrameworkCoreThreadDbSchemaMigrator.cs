using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Other.Thread.Data;
using Volo.Abp.DependencyInjection;

namespace Other.Thread.EntityFrameworkCore;

public class EntityFrameworkCoreThreadDbSchemaMigrator
    : IThreadDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreThreadDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ThreadDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ThreadDbContext>()
            .Database
            .MigrateAsync();
    }
}

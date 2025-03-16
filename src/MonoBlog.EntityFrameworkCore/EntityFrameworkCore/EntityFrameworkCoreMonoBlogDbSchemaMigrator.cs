using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MonoBlog.Data;
using Volo.Abp.DependencyInjection;

namespace MonoBlog.EntityFrameworkCore;

public class EntityFrameworkCoreMonoBlogDbSchemaMigrator
    : IMonoBlogDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMonoBlogDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the MonoBlogDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MonoBlogDbContext>()
            .Database
            .MigrateAsync();
    }
}
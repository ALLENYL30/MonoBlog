using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MonoBlog.Data;

/* This is used if database provider does't define
 * IMonoBlogDbSchemaMigrator implementation.
 */
public class NullMonoBlogDbSchemaMigrator : IMonoBlogDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
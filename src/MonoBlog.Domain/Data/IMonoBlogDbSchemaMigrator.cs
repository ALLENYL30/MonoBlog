using System.Threading.Tasks;

namespace MonoBlog.Data;

public interface IMonoBlogDbSchemaMigrator
{
    Task MigrateAsync();
}
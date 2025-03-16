using MonoBlog.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MonoBlog.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MonoBlogEntityFrameworkCoreModule),
    typeof(MonoBlogApplicationContractsModule)
)]
public class MonoBlogDbMigratorModule : AbpModule
{
}
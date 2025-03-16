using Volo.Abp.Modularity;

namespace MonoBlog;

[DependsOn(
    typeof(MonoBlogApplicationModule),
    typeof(MonoBlogDomainTestModule)
)]
public class MonoBlogApplicationTestModule : AbpModule
{
}
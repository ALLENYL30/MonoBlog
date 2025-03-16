using Volo.Abp.Modularity;

namespace MonoBlog;

[DependsOn(
    typeof(MonoBlogDomainModule),
    typeof(MonoBlogTestBaseModule)
)]
public class MonoBlogDomainTestModule : AbpModule
{
}
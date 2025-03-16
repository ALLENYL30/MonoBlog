using Volo.Abp.Modularity;

namespace MonoBlog;

public abstract class MonoBlogApplicationTestBase<TStartupModule> : MonoBlogTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
}
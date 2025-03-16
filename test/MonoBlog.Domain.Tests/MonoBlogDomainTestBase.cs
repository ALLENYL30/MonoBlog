using Volo.Abp.Modularity;

namespace MonoBlog;

/* Inherit from this class for your domain layer tests. */
public abstract class MonoBlogDomainTestBase<TStartupModule> : MonoBlogTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
}
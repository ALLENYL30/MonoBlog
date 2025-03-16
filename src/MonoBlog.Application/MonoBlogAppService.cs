using MonoBlog.Localization;
using Volo.Abp.Application.Services;

namespace MonoBlog;

/* Inherit your application services from this class.
 */
public abstract class MonoBlogAppService : ApplicationService
{
    protected MonoBlogAppService()
    {
        LocalizationResource = typeof(MonoBlogResource);
    }
}
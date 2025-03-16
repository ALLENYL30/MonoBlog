using MonoBlog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MonoBlog.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MonoBlogController : AbpControllerBase
{
    protected MonoBlogController()
    {
        LocalizationResource = typeof(MonoBlogResource);
    }
}
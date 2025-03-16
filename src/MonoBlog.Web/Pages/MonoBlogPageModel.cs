using MonoBlog.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MonoBlog.Web.Pages;

public abstract class MonoBlogPageModel : AbpPageModel
{
    protected MonoBlogPageModel()
    {
        LocalizationResourceType = typeof(MonoBlogResource);
    }
}
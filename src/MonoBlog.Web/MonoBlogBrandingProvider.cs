using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using MonoBlog.Localization;

namespace MonoBlog.Web;

[Dependency(ReplaceServices = true)]
public class MonoBlogBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<MonoBlogResource> _localizer;

    public MonoBlogBrandingProvider(IStringLocalizer<MonoBlogResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
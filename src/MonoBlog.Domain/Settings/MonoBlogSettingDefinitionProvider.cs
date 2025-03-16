using Volo.Abp.Settings;

namespace MonoBlog.Settings;

public class MonoBlogSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MonoBlogSettings.MySetting1));
    }
}
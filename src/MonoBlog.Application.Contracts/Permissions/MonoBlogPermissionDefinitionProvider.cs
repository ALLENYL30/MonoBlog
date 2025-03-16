using MonoBlog.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace MonoBlog.Permissions;

public class MonoBlogPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MonoBlogPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(MonoBlogPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MonoBlogResource>(name);
    }
}
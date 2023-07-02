using Kumojin.Evennements.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Kumojin.Evennements.Permissions;

public class EvennementsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EvennementsPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EvennementsPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EvennementsResource>(name);
    }
}

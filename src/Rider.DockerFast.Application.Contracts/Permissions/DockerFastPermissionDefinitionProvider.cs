using Rider.DockerFast.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Rider.DockerFast.Permissions;

public class DockerFastPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DockerFastPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DockerFastPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DockerFastResource>(name);
    }
}

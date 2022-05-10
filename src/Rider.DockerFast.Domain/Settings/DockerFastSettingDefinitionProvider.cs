using Volo.Abp.Settings;

namespace Rider.DockerFast.Settings;

public class DockerFastSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DockerFastSettings.MySetting1));
    }
}

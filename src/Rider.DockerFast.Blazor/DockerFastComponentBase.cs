using Rider.DockerFast.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Rider.DockerFast.Blazor;

public abstract class DockerFastComponentBase : AbpComponentBase
{
    protected DockerFastComponentBase()
    {
        LocalizationResource = typeof(DockerFastResource);
    }
}

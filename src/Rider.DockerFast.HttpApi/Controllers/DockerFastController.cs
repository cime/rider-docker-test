using Rider.DockerFast.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Rider.DockerFast.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DockerFastController : AbpControllerBase
{
    protected DockerFastController()
    {
        LocalizationResource = typeof(DockerFastResource);
    }
}

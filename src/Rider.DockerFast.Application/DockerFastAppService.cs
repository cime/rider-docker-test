using System;
using System.Collections.Generic;
using System.Text;
using Rider.DockerFast.Localization;
using Volo.Abp.Application.Services;

namespace Rider.DockerFast;

/* Inherit your application services from this class.
 */
public abstract class DockerFastAppService : ApplicationService
{
    protected DockerFastAppService()
    {
        LocalizationResource = typeof(DockerFastResource);
    }
}

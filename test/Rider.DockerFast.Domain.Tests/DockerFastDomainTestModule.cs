using Rider.DockerFast.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Rider.DockerFast;

[DependsOn(
    typeof(DockerFastEntityFrameworkCoreTestModule)
    )]
public class DockerFastDomainTestModule : AbpModule
{

}

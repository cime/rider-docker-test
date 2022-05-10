using Volo.Abp.Modularity;

namespace Rider.DockerFast;

[DependsOn(
    typeof(DockerFastApplicationModule),
    typeof(DockerFastDomainTestModule)
    )]
public class DockerFastApplicationTestModule : AbpModule
{

}

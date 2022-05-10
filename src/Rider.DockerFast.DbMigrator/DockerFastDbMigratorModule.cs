using Rider.DockerFast.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Rider.DockerFast.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DockerFastEntityFrameworkCoreModule),
    typeof(DockerFastApplicationContractsModule)
    )]
public class DockerFastDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}

using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Rider.DockerFast.Data;

/* This is used if database provider does't define
 * IDockerFastDbSchemaMigrator implementation.
 */
public class NullDockerFastDbSchemaMigrator : IDockerFastDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

using System.Threading.Tasks;

namespace Rider.DockerFast.Data;

public interface IDockerFastDbSchemaMigrator
{
    Task MigrateAsync();
}

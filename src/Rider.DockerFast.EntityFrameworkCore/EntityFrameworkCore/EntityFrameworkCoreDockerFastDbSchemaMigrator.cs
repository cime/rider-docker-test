using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rider.DockerFast.Data;
using Volo.Abp.DependencyInjection;

namespace Rider.DockerFast.EntityFrameworkCore;

public class EntityFrameworkCoreDockerFastDbSchemaMigrator
    : IDockerFastDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDockerFastDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the DockerFastDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DockerFastDbContext>()
            .Database
            .MigrateAsync();
    }
}

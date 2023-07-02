using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Kumojin.Evennements.Data;
using Volo.Abp.DependencyInjection;

namespace Kumojin.Evennements.EntityFrameworkCore;

public class EntityFrameworkCoreEvennementsDbSchemaMigrator
    : IEvennementsDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreEvennementsDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the EvennementsDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<EvennementsDbContext>()
            .Database
            .MigrateAsync();
    }
}

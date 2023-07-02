using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Kumojin.Evennements.Data;

/* This is used if database provider does't define
 * IEvennementsDbSchemaMigrator implementation.
 */
public class NullEvennementsDbSchemaMigrator : IEvennementsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

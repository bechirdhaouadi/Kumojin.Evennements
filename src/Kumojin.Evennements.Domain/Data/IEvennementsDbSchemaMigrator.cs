using System.Threading.Tasks;

namespace Kumojin.Evennements.Data;

public interface IEvennementsDbSchemaMigrator
{
    Task MigrateAsync();
}

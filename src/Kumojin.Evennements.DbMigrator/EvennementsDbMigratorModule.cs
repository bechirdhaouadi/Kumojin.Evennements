using Kumojin.Evennements.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Kumojin.Evennements.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EvennementsEntityFrameworkCoreModule),
    typeof(EvennementsApplicationContractsModule)
    )]
public class EvennementsDbMigratorModule : AbpModule
{

}

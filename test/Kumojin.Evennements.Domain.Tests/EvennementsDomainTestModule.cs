using Kumojin.Evennements.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Kumojin.Evennements;

[DependsOn(
    typeof(EvennementsEntityFrameworkCoreTestModule)
    )]
public class EvennementsDomainTestModule : AbpModule
{

}

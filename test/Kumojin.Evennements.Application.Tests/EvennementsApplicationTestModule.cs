using Volo.Abp.Modularity;

namespace Kumojin.Evennements;

[DependsOn(
    typeof(EvennementsApplicationModule),
    typeof(EvennementsDomainTestModule)
    )]
public class EvennementsApplicationTestModule : AbpModule
{

}

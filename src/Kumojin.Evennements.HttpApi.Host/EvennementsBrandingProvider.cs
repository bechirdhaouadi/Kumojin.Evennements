using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Kumojin.Evennements;

[Dependency(ReplaceServices = true)]
public class EvennementsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Evennements";
}

using Volo.Abp.Settings;

namespace Kumojin.Evennements.Settings;

public class EvennementsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EvennementsSettings.MySetting1));
    }
}

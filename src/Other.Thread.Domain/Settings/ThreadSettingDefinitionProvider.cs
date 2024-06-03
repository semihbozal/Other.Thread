using Volo.Abp.Settings;

namespace Other.Thread.Settings;

public class ThreadSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ThreadSettings.MySetting1));
    }
}

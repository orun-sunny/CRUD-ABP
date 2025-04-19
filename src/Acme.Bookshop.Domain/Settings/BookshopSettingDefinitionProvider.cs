using Volo.Abp.Settings;

namespace Acme.Bookshop.Settings;

public class BookshopSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookshopSettings.MySetting1));
    }
}

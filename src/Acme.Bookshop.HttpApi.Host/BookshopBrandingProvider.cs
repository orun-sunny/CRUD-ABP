using Microsoft.Extensions.Localization;
using Acme.Bookshop.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.Bookshop;

[Dependency(ReplaceServices = true)]
public class BookshopBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BookshopResource> _localizer;

    public BookshopBrandingProvider(IStringLocalizer<BookshopResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}

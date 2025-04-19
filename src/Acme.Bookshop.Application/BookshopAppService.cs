using Acme.Bookshop.Localization;
using Volo.Abp.Application.Services;

namespace Acme.Bookshop;

/* Inherit your application services from this class.
 */
public abstract class BookshopAppService : ApplicationService
{
    protected BookshopAppService()
    {
        LocalizationResource = typeof(BookshopResource);
    }
}

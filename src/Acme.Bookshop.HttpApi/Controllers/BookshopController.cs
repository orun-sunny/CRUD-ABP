using Acme.Bookshop.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Bookshop.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookshopController : AbpControllerBase
{
    protected BookshopController()
    {
        LocalizationResource = typeof(BookshopResource);
    }
}

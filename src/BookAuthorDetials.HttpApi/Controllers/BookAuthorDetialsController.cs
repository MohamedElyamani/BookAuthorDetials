using BookAuthorDetials.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BookAuthorDetials.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookAuthorDetialsController : AbpControllerBase
{
    protected BookAuthorDetialsController()
    {
        LocalizationResource = typeof(BookAuthorDetialsResource);
    }
}

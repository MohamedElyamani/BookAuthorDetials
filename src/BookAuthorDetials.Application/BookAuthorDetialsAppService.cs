using BookAuthorDetials.Localization;
using Volo.Abp.Application.Services;

namespace BookAuthorDetials;

/* Inherit your application services from this class.
 */
public abstract class BookAuthorDetialsAppService : ApplicationService
{
    protected BookAuthorDetialsAppService()
    {
        LocalizationResource = typeof(BookAuthorDetialsResource);
    }
}

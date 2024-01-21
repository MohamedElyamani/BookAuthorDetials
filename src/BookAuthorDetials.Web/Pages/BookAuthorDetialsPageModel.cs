using BookAuthorDetials.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace BookAuthorDetials.Web.Pages;

public abstract class BookAuthorDetialsPageModel : AbpPageModel
{
    protected BookAuthorDetialsPageModel()
    {
        LocalizationResourceType = typeof(BookAuthorDetialsResource);
    }
}

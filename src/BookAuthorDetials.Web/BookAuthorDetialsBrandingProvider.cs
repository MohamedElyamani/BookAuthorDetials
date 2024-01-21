using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace BookAuthorDetials.Web;

[Dependency(ReplaceServices = true)]
public class BookAuthorDetialsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BookAuthorDetials";
}

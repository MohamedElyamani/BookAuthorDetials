using Volo.Abp.Modularity;

namespace BookAuthorDetials;

[DependsOn(
    typeof(BookAuthorDetialsApplicationModule),
    typeof(BookAuthorDetialsDomainTestModule)
)]
public class BookAuthorDetialsApplicationTestModule : AbpModule
{

}

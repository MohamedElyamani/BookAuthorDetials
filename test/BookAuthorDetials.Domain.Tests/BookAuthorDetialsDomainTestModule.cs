using Volo.Abp.Modularity;

namespace BookAuthorDetials;

[DependsOn(
    typeof(BookAuthorDetialsDomainModule),
    typeof(BookAuthorDetialsTestBaseModule)
)]
public class BookAuthorDetialsDomainTestModule : AbpModule
{

}

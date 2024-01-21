using BookAuthorDetials.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BookAuthorDetials.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookAuthorDetialsEntityFrameworkCoreModule),
    typeof(BookAuthorDetialsApplicationContractsModule)
)]
public class BookAuthorDetialsDbMigratorModule : AbpModule
{
}

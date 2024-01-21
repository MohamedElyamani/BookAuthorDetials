using Volo.Abp.Modularity;

namespace BookAuthorDetials;

/* Inherit from this class for your domain layer tests. */
public abstract class BookAuthorDetialsDomainTestBase<TStartupModule> : BookAuthorDetialsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BookAuthorDetials.Data;

/* This is used if database provider does't define
 * IBookAuthorDetialsDbSchemaMigrator implementation.
 */
public class NullBookAuthorDetialsDbSchemaMigrator : IBookAuthorDetialsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

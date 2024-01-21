using System.Threading.Tasks;

namespace BookAuthorDetials.Data;

public interface IBookAuthorDetialsDbSchemaMigrator
{
    Task MigrateAsync();
}

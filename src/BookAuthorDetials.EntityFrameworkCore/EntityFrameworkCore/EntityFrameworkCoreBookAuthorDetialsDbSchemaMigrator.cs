using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookAuthorDetials.Data;
using Volo.Abp.DependencyInjection;

namespace BookAuthorDetials.EntityFrameworkCore;

public class EntityFrameworkCoreBookAuthorDetialsDbSchemaMigrator
    : IBookAuthorDetialsDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBookAuthorDetialsDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the BookAuthorDetialsDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BookAuthorDetialsDbContext>()
            .Database
            .MigrateAsync();
    }
}

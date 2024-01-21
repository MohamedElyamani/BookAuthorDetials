using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BookAuthorDetials.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BookAuthorDetialsDbContextFactory : IDesignTimeDbContextFactory<BookAuthorDetialsDbContext>
{
    public BookAuthorDetialsDbContext CreateDbContext(string[] args)
    {
        BookAuthorDetialsEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BookAuthorDetialsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new BookAuthorDetialsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../BookAuthorDetials.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}

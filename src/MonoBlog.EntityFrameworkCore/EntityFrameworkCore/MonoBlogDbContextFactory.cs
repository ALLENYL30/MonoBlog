using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MonoBlog.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class MonoBlogDbContextFactory : IDesignTimeDbContextFactory<MonoBlogDbContext>
{
    public MonoBlogDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        MonoBlogEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<MonoBlogDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new MonoBlogDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MonoBlog.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
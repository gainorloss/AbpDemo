﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Product.EntityFrameworkCore.DbMigartions
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */

    public class ProductMigrationsDbContextFactory : IDesignTimeDbContextFactory<ProductMigrationsDbContext>
    {
        public ProductMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ProductMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ProductMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Product.Host/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
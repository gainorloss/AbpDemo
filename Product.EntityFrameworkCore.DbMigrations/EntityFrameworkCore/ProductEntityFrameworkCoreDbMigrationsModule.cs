using Microsoft.Extensions.DependencyInjection;
using Product.EntityFrameworkCore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Product.EntityFrameworkCore.DbMigartions
{
    [DependsOn(
        typeof(ProductEntityFrameworkCoreModule)
        )]
    public class ProductEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ProductMigrationsDbContext>();
        }
    }
}
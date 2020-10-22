using Microsoft.EntityFrameworkCore;
using Product.Domain;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Product.EntityFrameworkCore.DbMigartions
{
    /* This DbContext is only used for database migrations.
     * It is not used on runtime. See EsopDbContext for the runtime DbContext.
     * It is a unified model that includes configuration for
     * all used modules and your application.
     */

    public class ProductMigrationsDbContext : AbpDbContext<ProductMigrationsDbContext>
    {
        public ProductMigrationsDbContext(DbContextOptions<ProductMigrationsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ProductEntity>(p =>
            {
                p.ToTable("product");
                p.ConfigureFullAudited();
            });
        }
    }
}
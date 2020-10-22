using Microsoft.EntityFrameworkCore;
using Product.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Product.EntityFrameworkCore.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class ProductDbContext : AbpDbContext<ProductDbContext>
    {
        public DbSet<ProductEntity> Products { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductEntity>(p =>
            {
                p.ToTable("product");
                p.ConfigureFullAudited();
            });
        }
    }
}

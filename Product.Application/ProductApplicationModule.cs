using Microsoft.Extensions.DependencyInjection;
using Product.Application.Constracts;
using Product.Domain;
using System;
using Volo.Abp.AutoMapper;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Product.Application
{
    [DependsOn(
        typeof(ProductDomainModule),
        typeof(ProductApplicationConstractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class ProductApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<ProductApplicationModule>();
            });
        }
    }
}

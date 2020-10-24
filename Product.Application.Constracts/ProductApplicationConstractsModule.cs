using System;
using Volo.Abp.Application;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Product.Application.Constracts
{
    [DependsOn(
        typeof(AbpIdentityApplicationContractsModule))]
    public class ProductApplicationConstractsModule : AbpModule
    {

    }
}

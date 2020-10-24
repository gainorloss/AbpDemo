using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Product.Domain.Shared
{
    [DependsOn(
        typeof(AbpIdentityDomainSharedModule))]
    public class ProductDomainSharedModule:AbpModule
    {
    }
}

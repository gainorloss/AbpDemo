using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.Identity;

namespace Product.Domain
{
    [DependsOn(
        typeof(AbpPermissionManagementDomainIdentityModule),
        typeof(AbpIdentityDomainModule))]
    public class ProductDomainModule : AbpModule
    {
    }
}

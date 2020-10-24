using Volo.Abp.Identity;
using Volo.Abp.IdentityServer;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.Identity;
using Volo.Abp.PermissionManagement.IdentityServer;

namespace Product.Domain
{
    [DependsOn(
        typeof(AbpPermissionManagementDomainIdentityServerModule),
        typeof(AbpIdentityServerDomainModule),
        typeof(AbpPermissionManagementDomainIdentityModule),
        typeof(AbpIdentityDomainModule))]
    public class ProductDomainModule : AbpModule
    {
    }
}

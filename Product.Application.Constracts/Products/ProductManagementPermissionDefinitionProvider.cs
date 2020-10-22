using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Authorization.Permissions;

namespace Product.Application.Constracts.Products
{
    public class ProductManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var productManagementGroup = context.AddGroup(ProductManagementPermissions.GroupName);

            var products = productManagementGroup.AddPermission(ProductManagementPermissions.Products.Default);
            products.AddChild(ProductManagementPermissions.Products.Update);
            products.AddChild(ProductManagementPermissions.Products.Delete);
            products.AddChild(ProductManagementPermissions.Products.Create);
        }
    }
}

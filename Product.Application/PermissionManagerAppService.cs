using Product.Application.Constracts.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.PermissionManagement;

namespace Product.Application
{
    public class PermissionManagerAppService : ApplicationService, IPermissionManagerAppService
    {
        private readonly IPermissionManager _manager;

        public PermissionManagerAppService(IPermissionManager manager)
        {
            _manager = manager;
        }

        public async Task GetAuthAsync()
        {
            
        }

        public async Task RemovePermissionAsync()
        {
            await _manager.SetAsync(ProductManagementPermissions.Products.Default, "C", "admin", false);
        }

        public async Task SetPermissionAsync()
        {
           await _manager.SetAsync(ProductManagementPermissions.Products.Default, "C", "admin", true);
        }
    }
}

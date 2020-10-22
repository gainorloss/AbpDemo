using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Product.Application.Constracts.Products
{
    public interface IPermissionManagerAppService : IApplicationService
    {
        Task SetPermissionAsync();

        Task RemovePermissionAsync();

        Task GetAuthAsync();
    }
}

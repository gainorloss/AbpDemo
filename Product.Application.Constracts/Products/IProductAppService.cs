using Product.Application.Constracts.Products.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Product.Application.Constracts.Products
{
    public interface IProductAppService : IApplicationService
    {
        Task<ProductDto> GetAsync(Guid id);

        Task CreateAsync(CreateProductInput input);

        Task DeleteAsync(Guid id);
    }
}

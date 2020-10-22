using Microsoft.AspNetCore.Authorization;
using Product.Application.Constracts.Products;
using Product.Application.Constracts.Products.Dto;
using Product.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Product.Application
{
    [Authorize(ProductManagementPermissions.Products.Default)]
    public class ProductAppService : ApplicationService, IProductAppService
    {
        private readonly IRepository<ProductEntity, Guid> _productRepository;

        public ProductAppService(IRepository<ProductEntity, Guid> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductDto>> GetListAsync()
        {
            var products = await _productRepository.GetListAsync();
            return ObjectMapper.Map<List<ProductEntity>, List<ProductDto>>(products);
        }

        public async Task<ProductDto> GetAsync(Guid id)
        {
            var product = await _productRepository.FindAsync(id);
            return ObjectMapper.Map<ProductEntity, ProductDto>(product);
        }

        [Authorize(ProductManagementPermissions.Products.Create)]
        public async Task CreateAsync(CreateProductInput input)
        {
            var product = new ProductEntity(GuidGenerator.Create(), input.Name, input.Price, input.Count);
            await _productRepository.InsertAsync(product);
        }

        [Authorize(ProductManagementPermissions.Products.Delete)]
        public async Task DeleteAsync(Guid id)
        {
            await _productRepository.DeleteAsync(id);
        }
    }
}

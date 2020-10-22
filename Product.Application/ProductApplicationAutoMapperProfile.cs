using AutoMapper;
using Product.Application.Constracts.Products.Dto;
using Product.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Application
{
    public class ProductApplicationAutoMapperProfile:Profile
    {
        public ProductApplicationAutoMapperProfile()
        {
            CreateMap<ProductEntity, ProductDto>().ReverseMap();
        }
    }
}

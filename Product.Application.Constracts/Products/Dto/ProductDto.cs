using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Product.Application.Constracts.Products.Dto
{
    public class ProductDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }
    }
}

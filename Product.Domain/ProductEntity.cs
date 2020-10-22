using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Product.Domain
{
    public class ProductEntity : FullAuditedEntity<Guid>
    {
        [Required]
        public string Name { get; protected set; }

        [Required]
        public decimal Price { get; protected set; }

        [Required]
        public int Count { get; protected set; }

        protected ProductEntity() { }

        public ProductEntity(Guid id, string name, decimal price, int count)
        {
            Id = id;
            Name = name;
            Price = price;
            Count = count;
        }
    }
}

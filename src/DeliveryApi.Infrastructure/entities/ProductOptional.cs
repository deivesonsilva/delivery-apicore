using System;
using System.Collections.Generic;

namespace DeliveryApi.Infrastructure.Entities
{
    public class ProductOptional : Entity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime? Disabled { get; set; }
        public bool IsActive { get; set; }

        public Product Product { get; set; }
        public Guid ProductId { get; set; }

        public ICollection<OrderItemOptional> OrderItemProductOptionals { get; set; }
    }
}

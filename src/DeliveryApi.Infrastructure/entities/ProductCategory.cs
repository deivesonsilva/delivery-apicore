using System;
using System.Collections.Generic;

namespace DeliveryApi.Infrastructure.entities
{
    public class ProductCategory : Entity
    {
        public string Name { get; set; }
        public DateTime? Disabled { get; set; }
        public bool IsActive { get; set; }
        public int? Position { get; set; }                  //Ordenação

        public ICollection<Product> Products { get; set; }
    }
}

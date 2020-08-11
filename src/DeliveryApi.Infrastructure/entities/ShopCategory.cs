using System;
using System.Collections.Generic;

namespace DeliveryApi.Infrastructure.entities
{
    public class ShopCategory : Entity
    {
        public string Name { get; set; }                //Pizzaria, Sorveteria, Lanche...
        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Shop> Shops { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DeliveryApi.Infrastructure.entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }                  //Valor
        public decimal AmountSold { get; set; }             //Quantidade Vendida
        public DateTime? Disabled { get; set; }             //Excluido
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ImageUrl { get; set; }

        public Shop Shop { get; set; }
        public Guid ShopId { get; set; }

        public ProductCategory Category { get; set; }
        public Guid CategoryId { get; set; }

        public ICollection<ProductOptional> Optionals { get; set; }
        public ICollection<OrderItem> OrderProductItens { get; set; }
    }
}

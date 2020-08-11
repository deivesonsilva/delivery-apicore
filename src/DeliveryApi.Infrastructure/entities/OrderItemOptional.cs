using System;
namespace DeliveryApi.Infrastructure.entities
{
    public class OrderItemOptional : Entity
    {
        public decimal Price { get; set; }

        public ProductOptional ProductOptional { get; set; }
        public Guid ProductOptionalId { get; set; }

        public OrderItem OrderItem { get; set; }
        public Guid OrderItemId { get; set; }
    }
}

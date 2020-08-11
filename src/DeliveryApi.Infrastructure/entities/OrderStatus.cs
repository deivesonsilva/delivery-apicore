using System;
using System.Collections.Generic;

namespace DeliveryApi.Infrastructure.entities
{
    public class OrderStatus : Entity
    {
        public string Name { get; set; }
        public DateTime? Disabled { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}

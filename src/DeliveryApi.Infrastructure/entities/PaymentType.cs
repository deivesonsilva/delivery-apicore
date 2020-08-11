using System;
using System.Collections.Generic;

namespace DeliveryApi.Infrastructure.Entities
{
    public class PaymentType : Entity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime? Disabled { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DeliveryApi.Infrastructure.entities
{
    public class Department : Entity
    {
        public string Name { get; set; }
        public DateTime? Disabled { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DeliveryApi.Infrastructure.entities
{
    public class Account : Entity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsConfirmed { get; set; }
        public string VerifyCode { get; set; }
        public int Type { get; set; }               //Cliente, Comerciante
        public string ResetPassword { get; set; }
        public Guid? AccountMasterId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastSignin { get; set; }

        public bool IsActive { get; set; }
        public string Document { get; set; }

        public ICollection<CustomerAddress> Addresses { get; set; }
        public ICollection<Shop> Shops { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<ShopRating> Ratings { get; set; }
    }
}

using System;
namespace DeliveryApi.Infrastructure.Entities
{
    public class CustomerAddress : Entity
    {
        public string AddressOne { get; set; }          
        public string AddressTwo { get; set; }          
        public string Number { get; set; }              
        public string Type { get; set; }                //Casa ou Trabalho
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }             
        public bool IsDefault { get; set; }               
        public DateTime? Disabled { get; set; }

        public Account Customer { get; set; }           
        public Guid CustomerId { get; set; }

        public Order Order { get; set; }
    }
}

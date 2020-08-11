using System;
namespace DeliveryApi.Infrastructure.Entities
{
    public class ShopRating : Entity
    {
        public int Rating { get; set; }                 //Avaliação
        public string Description { get; set; }         //Comentario
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }              //Exibe a avaliação

        public Account Customer { get; set; }           //Cliente
        public Guid CustomerId { get; set; }

        public Shop Shop { get; set; }
        public Guid ShopId { get; set; }
    }
}

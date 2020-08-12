using System;
namespace DeliveryApi.Infrastructure.Entities
{
    public class ShopCoupon : Entity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime ExpirationDate { get; set; }    //Data de vencimento
        public string Code { get; set; }                //Codigo
        public bool IsUsed { get; set; }                //Foi utilizado
        public int ValuePercentual { get; set; }        //Valor do cupom

        public Shop Shop { get; set; }
        public Guid ShopId { get; set; }

        public Order Order { get; set; }
    }
}

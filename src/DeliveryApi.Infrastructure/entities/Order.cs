using System;
using System.Collections.Generic;

namespace DeliveryApi.Infrastructure.Entities
{
    public class Order : Entity
    {
        public decimal ValueOrder { get; set; }                 //Total do pedido
        public decimal? ValueCashback { get; set; }             //Valor pago com cashback
        public decimal? ValueCupom { get; set; }                //Valor do cupom
        public decimal? ValueDelivery { get; set; }             //Valor da entrega
        public decimal Amount { get; set; }                     //Total com os descontos
        public int? Rating { get; set; }                        //Avaliação do pedido
        public bool IsDelivery { get; set; }                    //Se for entrega, tem endereço
        public int OrderNumber { get; set; }
        public DateTime CreatedAt { get; set; }                 //Pedido feito em
        public DateTime? DeliveryAt { get; set; }               //Pedido Entregue em

        public OrderStatus OrderStatus { get; set; }            //Status
        public Guid OrderStatusId { get; set; }

        public CustomerAddress AddressDelivery { get; set; }    //Endereço entrega
        public Guid? AddressDeliveryId { get; set; }

        public Account Customer { get; set; }                   //Cliente
        public Guid CustomerId { get; set; }

        public Shop Shop { get; set; }                          //Comercio
        public Guid ShopId { get; set; }

        public PaymentType PaymentType { get; set; }            //Forma de pagamento
        public Guid PaymentTypeId { get; set; }

        public ShopCoupon ShopCoupon { get; set; }              //Cupom desconto
        public Guid? ShopCouponId { get; set; }

        public ICollection<OrderItem> OrderProductItens { get; set; }
    }
}

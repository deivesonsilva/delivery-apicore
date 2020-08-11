using System;
using System.Collections.Generic;

namespace DeliveryApi.Infrastructure.Entities
{
    public class OrderItem : Entity
    {
        public int Quantity { get; set; }                   //Quantidade
        public int Price { get; set; }                      //Valor do item
        public decimal Amount { get; set; }                 //Total do item
        public string Note { get; set; }                    //Observação
        public string OptionalInline { get; set; }          //Opcionais concatenados
        public decimal AmountOptional { get; set; }         //Total de opcionais

        public Product Product { get; set; }                //Produto
        public Guid ProductId { get; set; }

        public Order Order { get; set; }                    //Pedido
        public Guid OrderId { get; set; }

        public ICollection<OrderItemOptional> OrderItemProductOptionals { get; set; }
    }
}

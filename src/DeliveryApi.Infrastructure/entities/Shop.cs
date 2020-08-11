using System;
using System.Collections.Generic;

namespace DeliveryApi.Infrastructure.entities
{
    public class Shop : Entity
    {
        public string Name { get; set; }                //Nome Estabelecimento
        public string Description { get; set; }         //Breve resumo do estabelicimento
        public int? RatingAvg { get; set; }             //Média Avaliação
        public int? WaitTime { get; set; }              //Fila de espera
        public DateTime? Disabled { get; set; }         //Quando excluido
        public bool IsActive { get; set; }              //Desativa temporariamente
        public bool IsDelivery { get; set; }            //Faz entrega
        public decimal? ValueDelivery { get; set; }     //Valor do Frete
        public bool IsWithdrawShop { get; set; }        //Retirar na loja
        public string PhoneNumber { get; set; }         //Contato

        public string AddressOne { get; set; }          //Endereco
        public string AddressTwo { get; set; }          //Complemento
        public string Number { get; set; }              //Numero
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }             //Cep

        public ShopCategory Category { get; set; }      //Pizzaria, Sorveteria, Lanche...
        public Guid CategoryId { get; set; }

        public Account Manager { get; set; }            //Gerente
        public Guid ManagerId { get; set; }

        public ICollection<ShopRating> Ratings { get; set; }
        public ICollection<ShopSchedule> Schedules { get; set; }
        public ICollection<ShopCoupon> Coupons { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}

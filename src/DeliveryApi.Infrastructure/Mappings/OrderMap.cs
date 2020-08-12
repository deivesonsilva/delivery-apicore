using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class OrderMap : IEntityTypeConfiguration<Order>
   {
      public void Configure(EntityTypeBuilder<Order> builder)
      {
            builder.ToTable("Order");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ValueOrder).HasColumnType("decimal(18,2)");
            builder.Property(x => x.ValueCashback).HasColumnType("decimal(18,2)");
            builder.Property(x => x.ValueCupom).HasColumnType("decimal(18,2)");
            builder.Property(x => x.ValueDelivery).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Amount).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Rating);
            builder.Property(x => x.IsDelivery).HasDefaultValue(false);
            builder.Property(x => x.OrderNumber);
            builder.Property(x => x.CreatedAt);
            builder.Property(x => x.DeliveryAt);

            builder.HasOne(a => a.OrderStatus)
                .WithMany(b => b.Orders)
                .HasForeignKey(c => c.OrderStatusId);

            builder.HasOne(a => a.AddressDelivery)
                .WithOne(b => b.Order)
                .HasForeignKey<Order>(c => c.AddressDeliveryId);

            builder.HasOne(a => a.Customer)
                .WithMany(b => b.Orders)
                .HasForeignKey(c => c.CustomerId);

            builder.HasOne(a => a.Shop)
                .WithMany(b => b.Orders)
                .HasForeignKey(c => c.ShopId);

            builder.HasOne(a => a.PaymentType)
                .WithMany(b => b.Orders)
                .HasForeignKey(c => c.PaymentTypeId);

            builder.HasOne(a => a.ShopCoupon)
                .WithOne(b => b.Order)
                .HasForeignKey<Order>(c => c.ShopCouponId);

            builder.HasIndex(a => a.OrderStatusId).IsUnique(false);
            builder.HasIndex(a => a.AddressDeliveryId).IsUnique(false);
            builder.HasIndex(a => a.CustomerId).IsUnique(false);
            builder.HasIndex(a => a.ShopId).IsUnique(false);
            builder.HasIndex(a => a.PaymentTypeId).IsUnique(false);
            builder.HasIndex(a => a.ShopCouponId).IsUnique(false);
        }
   }
}

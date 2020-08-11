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
            builder.Property(x => x.ValueOrder);
            builder.Property(x => x.ValueCashback);
            builder.Property(x => x.ValueCupom);
            builder.Property(x => x.ValueDelivery);
            builder.Property(x => x.Amount);
            builder.Property(x => x.Rating);
            builder.Property(x => x.IsDelivery).HasDefaultValue(false);
            builder.Property(x => x.OrderNumber);
            builder.Property(x => x.CreatedAt);
            builder.Property(x => x.DeliveryAt);
      }
   }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class OrderStatusMap : IEntityTypeConfiguration<OrderStatus>
   {
      public void Configure(EntityTypeBuilder<OrderStatus> builder)
      {
            builder.ToTable("OrderStatus");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Disabled);
      }
   }
}

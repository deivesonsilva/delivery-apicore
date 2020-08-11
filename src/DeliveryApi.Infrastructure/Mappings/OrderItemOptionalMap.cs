using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class OrderItemOptionalMap : IEntityTypeConfiguration<OrderItemOptional>
   {
      public void Configure(EntityTypeBuilder<OrderItemOptional> builder)
      {
            builder.ToTable("OrderItemOptional");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price);
      }
   }
}

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

            builder.HasOne(a => a.ProductOptional)
                .WithMany(b => b.OrderItemProductOptionals)
                .HasForeignKey(c => c.ProductOptionalId);

            builder.HasOne(a => a.OrderItem)
                .WithMany(b => b.OrderItemProductOptionals)
                .HasForeignKey(c => c.OrderItemId);

            builder.HasIndex(a => a.ProductOptionalId).IsUnique(false);
            builder.HasIndex(a => a.OrderItemId).IsUnique(false);
        }
   }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class OrderItemMap : IEntityTypeConfiguration<OrderItem>
   {
      public void Configure(EntityTypeBuilder<OrderItem> builder)
      {
            builder.ToTable("OrderItem");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantity);
            builder.Property(x => x.Price);
            builder.Property(x => x.Amount);
            builder.Property(x => x.Note);
            builder.Property(x => x.OptionalInline).HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(x => x.AmountOptional);
      }
   }
}

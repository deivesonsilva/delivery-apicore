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
            builder.Property(x => x.Note).HasMaxLength(200).HasColumnType("varchar(200)"); ;
            builder.Property(x => x.OptionalInline);
            builder.Property(x => x.AmountOptional);

            builder.HasOne(a => a.Order)
                .WithMany(b => b.OrderProductItens)
                .HasForeignKey(c => c.OrderId);

            builder.HasOne(a => a.Product)
                .WithMany(b => b.OrderProductItens)
                .HasForeignKey(c => c.ProductId);

            builder.HasIndex(a => a.OrderId).IsUnique(false);
            builder.HasIndex(a => a.ProductId).IsUnique(false);
        }
   }
}

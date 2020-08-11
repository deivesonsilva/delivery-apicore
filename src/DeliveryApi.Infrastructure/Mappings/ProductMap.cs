using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class ProductMap : IEntityTypeConfiguration<Product>
   {
      public void Configure(EntityTypeBuilder<Product> builder)
      {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(120).HasColumnType("varchar(120)").IsRequired();
            builder.Property(x => x.Description).HasMaxLength(400).HasColumnType("varchar(400)");
            builder.Property(x => x.Price);
            builder.Property(x => x.AmountSold);
            builder.Property(x => x.Disabled);
            builder.Property(x => x.IsActive).HasDefaultValue("true");
            builder.Property(x => x.CreatedAt);
            builder.Property(x => x.ImageUrl);
      }
   }
}

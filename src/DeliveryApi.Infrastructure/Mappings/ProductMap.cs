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
            builder.Property(x => x.Description);
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
            builder.Property(x => x.AmountSold).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Disabled);
            builder.Property(x => x.IsActive).HasDefaultValue("true");
            builder.Property(x => x.CreatedAt);
            builder.Property(x => x.ImageUrl);

            builder.HasOne(a => a.Shop)
                .WithMany(b => b.Products)
                .HasForeignKey(c => c.ShopId);

            builder.HasOne(a => a.Category)
                .WithMany(b => b.Products)
                .HasForeignKey(c => c.CategoryId);

            builder.HasIndex(a => a.ShopId).IsUnique(false);
            builder.HasIndex(a => a.CategoryId).IsUnique(false);
        }
   }
}

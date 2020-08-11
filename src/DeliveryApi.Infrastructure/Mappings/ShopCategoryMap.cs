using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class ShopCategoryMap : IEntityTypeConfiguration<ShopCategory>
   {
      public void Configure(EntityTypeBuilder<ShopCategory> builder)
      {
            builder.ToTable("ShopCategory");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(120).HasColumnType("varchar(120)").IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.ImageUrl).HasMaxLength(200).HasColumnType("varchar(200)");
      }
   }
}

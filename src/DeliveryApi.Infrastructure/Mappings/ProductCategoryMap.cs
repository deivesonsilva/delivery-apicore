using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class ProductCategoryMap : IEntityTypeConfiguration<ProductCategory>
   {
      public void Configure(EntityTypeBuilder<ProductCategory> builder)
      {
            builder.ToTable("ProductCategory");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(x => x.Disabled);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.Position);
      }
   }
}

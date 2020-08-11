using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class ProductOptionalMap : IEntityTypeConfiguration<ProductOptional>
   {
      public void Configure(EntityTypeBuilder<ProductOptional> builder)
      {
            builder.ToTable("ProductOptional");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(120).HasColumnType("varchar(120)").IsRequired();
            builder.Property(x => x.Price);
            builder.Property(x => x.Disabled);
            builder.Property(x => x.IsActive);

            builder.HasOne(a => a.Product)
                .WithMany(b => b.Optionals)
                .HasForeignKey(c => c.ProductId);

            builder.HasIndex(a => a.ProductId).IsUnique(false);
        }
   }
}

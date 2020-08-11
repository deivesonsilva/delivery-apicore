using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class ShopRatingMap : IEntityTypeConfiguration<ShopRating>
   {
      public void Configure(EntityTypeBuilder<ShopRating> builder)
      {
            builder.ToTable("ShopRating");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Rating);
            builder.Property(x => x.Description).HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(x => x.CreatedAt);
            builder.Property(x => x.IsActive).HasDefaultValue(false);

            builder.HasOne(a => a.Customer)
                .WithMany(b => b.Ratings)
                .HasForeignKey(c => c.CustomerId);

            builder.HasOne(a => a.Shop)
                .WithMany(b => b.Ratings)
                .HasForeignKey(c => c.ShopId);

            builder.HasIndex(a => a.CustomerId).IsUnique(false);
            builder.HasIndex(a => a.ShopId).IsUnique(false);
        }
   }
}

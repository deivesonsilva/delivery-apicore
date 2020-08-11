using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class ShopCouponMap : IEntityTypeConfiguration<ShopCoupon>
   {
      public void Configure(EntityTypeBuilder<ShopCoupon> builder)
      {
            builder.ToTable("ShopCoupon");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedAt);
            builder.Property(x => x.ExpirationDate);
            builder.Property(x => x.Code).HasMaxLength(20).HasColumnType("varchar(20)").IsRequired();
            builder.Property(x => x.IsUsed).HasDefaultValue(false);
            builder.Property(x => x.Value);

            builder.HasOne(a => a.Shop)
                .WithMany(b => b.Coupons)
                .HasForeignKey(c => c.ShopId);

            builder.HasIndex(a => a.ShopId).IsUnique(false);
        }
   }
}

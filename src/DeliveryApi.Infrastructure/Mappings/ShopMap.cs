using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class ShopMap : IEntityTypeConfiguration<Shop>
   {
      public void Configure(EntityTypeBuilder<Shop> builder)
      {
            builder.ToTable("Shop");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(120).HasColumnType("varchar(120)").IsRequired();
            builder.Property(x => x.Description);
            builder.Property(x => x.RatingAvg);
            builder.Property(x => x.WaitTime);
            builder.Property(x => x.Disabled);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.IsDelivery).HasDefaultValue(false);
            builder.Property(x => x.ValueDelivery).HasColumnType("decimal(18,2)");
            builder.Property(x => x.IsWithdrawShop).HasDefaultValue(false);
            builder.Property(x => x.PhoneNumber).HasMaxLength(20).HasColumnType("varchar(20)");

            builder.Property(x => x.AddressOne).HasMaxLength(200).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.AddressTwo).HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(x => x.Number).HasMaxLength(10).HasColumnType("varchar(10)").IsRequired();
            builder.Property(x => x.City).HasMaxLength(200).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.State).HasMaxLength(2).HasColumnType("varchar(2)").IsRequired();
            builder.Property(x => x.ZipCode).HasMaxLength(8).HasColumnType("varchar(8)");

            builder.HasOne(a => a.Category)
                .WithMany(b => b.Shops)
                .HasForeignKey(c => c.CategoryId);

            builder.HasOne(a => a.Manager)
                .WithMany(b => b.Shops)
                .HasForeignKey(c => c.ManagerId);

            builder.HasIndex(a => a.CategoryId).IsUnique(false);
            builder.HasIndex(a => a.ManagerId).IsUnique(false);
        }
   }
}

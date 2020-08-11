using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class ShopScheduleMap : IEntityTypeConfiguration<ShopSchedule>
   {
      public void Configure(EntityTypeBuilder<ShopSchedule> builder)
      {
            builder.ToTable("ShopSchedule");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DayOfWeek).HasMaxLength(20).HasColumnType("varchar(20)").IsRequired();
            builder.Property(x => x.OpenAt);
            builder.Property(x => x.CloseAt);
            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.HasOne(a => a.Shop)
                .WithMany(b => b.Schedules)
                .HasForeignKey(c => c.ShopId);
        }
   }
}

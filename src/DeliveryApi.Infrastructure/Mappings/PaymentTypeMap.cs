using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class PaymentTypeMap : IEntityTypeConfiguration<PaymentType>
   {
      public void Configure(EntityTypeBuilder<PaymentType> builder)
      {
            builder.ToTable("PaymentType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.Disabled);
      }
   }
}

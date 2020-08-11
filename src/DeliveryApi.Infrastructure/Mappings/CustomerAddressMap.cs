using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class CustomerAddressMap : IEntityTypeConfiguration<CustomerAddress>
   {
      public void Configure(EntityTypeBuilder<CustomerAddress> builder)
      {
            builder.ToTable("CustomerAddress");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AddressOne).HasMaxLength(200).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.AddressTwo).HasMaxLength(200).HasColumnType("varchar(200)");
            builder.Property(x => x.Number).HasMaxLength(10).HasColumnType("varchar(10)").IsRequired();
            builder.Property(x => x.Type);
            builder.Property(x => x.City).HasMaxLength(200).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.State).HasMaxLength(2).HasColumnType("varchar(2)").IsRequired();
            builder.Property(x => x.ZipCode).HasMaxLength(8).HasColumnType("varchar(8)");
            builder.Property(x => x.Default).HasDefaultValue(false);
            builder.Property(x => x.Disabled);
      }
   }
}

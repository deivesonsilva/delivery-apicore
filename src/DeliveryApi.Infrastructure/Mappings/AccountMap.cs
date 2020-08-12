using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DeliveryApi.Infrastructure.Entities;

namespace DeliveryApi.Infrastructure.Mappings
{
   public class AccountMap : IEntityTypeConfiguration<Account>
   {
      public void Configure(EntityTypeBuilder<Account> builder)
      {
            builder.ToTable("Account");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).HasMaxLength(45).HasColumnType("varchar(45)").IsRequired();
            builder.Property(x => x.SecondName).HasMaxLength(45).HasColumnType("varchar(45)");
            builder.Property(x => x.Email).HasMaxLength(200).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.Password).HasMaxLength(32).HasColumnType("varchar(32)").IsRequired();
            builder.Property(x => x.IsConfirmed).HasDefaultValue(false);
            builder.Property(x => x.VerifyCode).HasMaxLength(32).HasColumnType("varchar(32)");
            builder.Property(x => x.Type);
            builder.Property(x => x.ResetPassword).HasMaxLength(32).HasColumnType("varchar(32)");
            builder.Property(x => x.AccountMasterId);
            builder.Property(x => x.CreatedAt);
            builder.Property(x => x.LastSignin);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.DocumentNumber).HasMaxLength(20).HasColumnType("varchar(20)");

            builder.HasIndex(a => a.AccountMasterId).IsUnique(false);
        }
   }
}

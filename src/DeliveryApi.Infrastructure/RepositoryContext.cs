using Microsoft.EntityFrameworkCore;
using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Mappings;

namespace DeliveryApi.Infrastructure
{
   public class RepositoryContext : DbContext
   {
      public RepositoryContext(DbContextOptions<RepositoryContext> options)
         : base(options) { }

      protected override void OnModelCreating(ModelBuilder builder)
      {
         builder.ApplyConfiguration(new ShopScheduleMap());
         builder.ApplyConfiguration(new OrderMap());
         builder.ApplyConfiguration(new ShopCategoryMap());
         builder.ApplyConfiguration(new OrderStatusMap());
         builder.ApplyConfiguration(new ProductCategoryMap());
         builder.ApplyConfiguration(new PaymentTypeMap());
         builder.ApplyConfiguration(new ShopRatingMap());
         builder.ApplyConfiguration(new ShopCouponMap());
         builder.ApplyConfiguration(new OrderItemMap());
         builder.ApplyConfiguration(new OrderItemOptionalMap());
         builder.ApplyConfiguration(new ShopMap());
         builder.ApplyConfiguration(new ProductOptionalMap());
         builder.ApplyConfiguration(new AccountMap());
         builder.ApplyConfiguration(new CustomerAddressMap());
         builder.ApplyConfiguration(new ProductMap());
      }

      public DbSet<ShopSchedule> ShopSchedules { get; set; }
      public DbSet<Order> Orders { get; set; }
      public DbSet<ShopCategory> ShopCategories { get; set; }
      public DbSet<OrderStatus> OrderStatuses { get; set; }
      public DbSet<ProductCategory> ProductCategories { get; set; }
      public DbSet<PaymentType> PaymentTypes { get; set; }
      public DbSet<ShopRating> ShopRatings { get; set; }
      public DbSet<ShopCoupon> ShopCoupons { get; set; }
      public DbSet<OrderItem> OrderItems { get; set; }
      public DbSet<OrderItemOptional> OrderItemOptionals { get; set; }
      public DbSet<Shop> Shops { get; set; }
      public DbSet<ProductOptional> ProductOptionals { get; set; }
      public DbSet<Account> Accounts { get; set; }
      public DbSet<CustomerAddress> CustomerAddresses { get; set; }
      public DbSet<Product> Products { get; set; }
   }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DeliveryApi.Infrastructure.Interfaces;
using DeliveryApi.Infrastructure.Repositories;
using System;

namespace DeliveryApi.Infrastructure
{
   public static class InitializeInfrastructure
   {
      public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
      {
         services.AddDbContext<RepositoryContext>(options =>
            options.UseMySql(
               configuration.GetConnectionString("DefaultConnection")));

         services.AddScoped<IRepositoryUnitWork, RepositoryUnitWork>();
         services.AddTransient<IShopScheduleRepository, ShopScheduleRepository>();
         services.AddTransient<IOrderRepository, OrderRepository>();
         services.AddTransient<IShopCategoryRepository, ShopCategoryRepository>();
         services.AddTransient<IOrderStatusRepository, OrderStatusRepository>();
         services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
         services.AddTransient<IPaymentTypeRepository, PaymentTypeRepository>();
         services.AddTransient<IShopRatingRepository, ShopRatingRepository>();
         services.AddTransient<IShopCouponRepository, ShopCouponRepository>();
         services.AddTransient<IOrderItemRepository, OrderItemRepository>();
         services.AddTransient<IOrderItemOptionalRepository, OrderItemOptionalRepository>();
         services.AddTransient<IShopRepository, ShopRepository>();
         services.AddTransient<IProductOptionalRepository, ProductOptionalRepository>();
         services.AddTransient<IAccountRepository, AccountRepository>();
         services.AddTransient<ICustomerAddressRepository, CustomerAddressRepository>();
         services.AddTransient<IProductRepository, ProductRepository>();
      }

      public static void ConfigureUpdateDatebase(this IApplicationBuilder app)
      {
            using (var serviceScope = app.ApplicationServices
                   .GetRequiredService<IServiceScopeFactory>()
                   .CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<RepositoryContext>())
                {
                    context.Database.EnsureCreated();
                }
            }
        }
   }
}

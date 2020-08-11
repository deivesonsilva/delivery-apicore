using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DeliveryApi.Infrastructure
{
   public static class InitializeInfrastructure
   {
      public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
      {
         services.AddDbContext<RepositoryContext>(options =>
            options.UseMySql(
               configuration.GetConnectionString("DefaultConnection")));
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

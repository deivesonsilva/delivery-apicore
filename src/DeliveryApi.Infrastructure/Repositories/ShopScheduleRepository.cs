using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class ShopScheduleRepository : RepositoryBase<ShopSchedule>, IShopScheduleRepository
   {
      public ShopScheduleRepository(RepositoryContext context) : base(context)
      {
      }
   }
}

using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class ShopRepository : RepositoryBase<Shop>, IShopRepository
   {
      public ShopRepository(RepositoryContext context) : base(context)
      {
      }
   }
}

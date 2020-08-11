using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class ShopCategoryRepository : RepositoryBase<ShopCategory>, IShopCategoryRepository
   {
      public ShopCategoryRepository(RepositoryContext context) : base(context)
      {
      }
   }
}

using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class ShopCouponRepository : RepositoryBase<ShopCoupon>, IShopCouponRepository
   {
      public ShopCouponRepository(RepositoryContext context) : base(context)
      {
      }
   }
}

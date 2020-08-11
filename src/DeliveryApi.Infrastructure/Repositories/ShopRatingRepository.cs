using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class ShopRatingRepository : RepositoryBase<ShopRating>, IShopRatingRepository
   {
      public ShopRatingRepository(RepositoryContext context) : base(context)
      {
      }
   }
}

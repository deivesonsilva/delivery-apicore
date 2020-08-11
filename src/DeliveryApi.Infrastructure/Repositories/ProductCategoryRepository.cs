using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
   {
      public ProductCategoryRepository(RepositoryContext context) : base(context)
      {
      }
   }
}

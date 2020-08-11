using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class ProductOptionalRepository : RepositoryBase<ProductOptional>, IProductOptionalRepository
   {
      public ProductOptionalRepository(RepositoryContext context) : base(context)
      {
      }
   }
}

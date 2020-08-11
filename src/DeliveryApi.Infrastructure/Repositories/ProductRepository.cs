using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class ProductRepository : RepositoryBase<Product>, IProductRepository
   {
      public ProductRepository(RepositoryContext context) : base(context)
      {
      }
   }
}

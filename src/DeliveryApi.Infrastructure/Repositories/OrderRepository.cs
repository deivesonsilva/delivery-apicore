using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class OrderRepository : RepositoryBase<Order>, IOrderRepository
   {
      public OrderRepository(RepositoryContext context) : base(context)
      {
      }
   }
}

using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class OrderStatusRepository : RepositoryBase<OrderStatus>, IOrderStatusRepository
   {
      public OrderStatusRepository(RepositoryContext context) : base(context)
      {
      }
   }
}

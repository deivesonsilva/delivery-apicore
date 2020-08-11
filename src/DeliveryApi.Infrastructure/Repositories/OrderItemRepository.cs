using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class OrderItemRepository : RepositoryBase<OrderItem>, IOrderItemRepository
   {
      public OrderItemRepository(RepositoryContext context) : base(context)
      {
      }
   }
}

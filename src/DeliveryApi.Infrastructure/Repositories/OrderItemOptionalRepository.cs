using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class OrderItemOptionalRepository : RepositoryBase<OrderItemOptional>, IOrderItemOptionalRepository
   {
      public OrderItemOptionalRepository(RepositoryContext context) : base(context)
      {
      }
   }
}

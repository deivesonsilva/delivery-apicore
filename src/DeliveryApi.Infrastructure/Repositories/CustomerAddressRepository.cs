using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class CustomerAddressRepository : RepositoryBase<CustomerAddress>, ICustomerAddressRepository
   {
      public CustomerAddressRepository(RepositoryContext context) : base(context)
      {
      }
   }
}

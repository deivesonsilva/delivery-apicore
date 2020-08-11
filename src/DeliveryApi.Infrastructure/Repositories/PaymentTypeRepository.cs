using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class PaymentTypeRepository : RepositoryBase<PaymentType>, IPaymentTypeRepository
   {
      public PaymentTypeRepository(RepositoryContext context) : base(context)
      {
      }
   }
}

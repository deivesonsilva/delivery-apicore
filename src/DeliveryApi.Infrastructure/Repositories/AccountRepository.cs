using DeliveryApi.Infrastructure.Entities;
using DeliveryApi.Infrastructure.Interfaces;

namespace DeliveryApi.Infrastructure.Repositories
{
   public class AccountRepository : RepositoryBase<Account>, IAccountRepository
   {
      public AccountRepository(RepositoryContext context) : base(context) { }
   }
}

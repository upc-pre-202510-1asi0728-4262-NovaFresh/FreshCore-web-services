using FreshCore.API.AccountSubscription.Domain.Models.Aggregates;
using FreshCore.API.AccountSubscription.Domain.Repositories;
using FreshCore.API.Shared.Infrastructure;
using FreshCore.API.Shared.Infrastructure.Repositories;

namespace FreshCore.API.AccountSubscription.Infrastructure.Repositories
{
    public class AccountRepository(ApplicationDbContext context) : BaseRepository<Account>(context), IAccountRepository
    {
    }
}

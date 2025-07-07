using FreshCore.API.AccountSubscription.Application.Handlers.Interfaces;
using FreshCore.API.AccountSubscription.Application.Queries;
using FreshCore.API.AccountSubscription.Application.Resources;
using FreshCore.API.AccountSubscription.Domain.Services.Application;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Internal
{
    public class GetAccountDetailsQueryHandler(
		IAccountService accountService
	) : IGetAccountDetailsQueryHandler
    {
        public async Task<AccountResource?> Handle(GetAccountDetailsQuery query)
        {

			var result = await accountService.GetAccount(query.AccountId);
			return result == null ? null : AccountResource.FromAccount(result);
        }
    }
}

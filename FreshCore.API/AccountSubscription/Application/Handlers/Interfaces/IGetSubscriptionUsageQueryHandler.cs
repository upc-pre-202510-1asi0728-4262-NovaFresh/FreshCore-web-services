using FreshCore.API.AccountSubscription.Application.Queries;
using FreshCore.API.AccountSubscription.Application.Resources;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Interfaces
{
	public interface IGetSubscriptionUsageQueryHandler
	{
		Task<AccountUsageResource> Handle(GetSubscriptionUsageQuery query);
	}
}
using FreshCore.API.AccountSubscription.Application.Handlers.Interfaces;
using FreshCore.API.AccountSubscription.Application.Queries;
using FreshCore.API.AccountSubscription.Application.Resources;
using FreshCore.API.AccountSubscription.Domain.Models.ValueObjects;
using FreshCore.API.AccountSubscription.Domain.Services.Application;
using FreshCore.API.Shared.Domain.Repositories;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Internal
{
    public class GetSubscriptionDetailsQueryHandler(
		ISubscriptionService subscriptionService
		)
		 : IGetSubscriptionDetailsQueryHandler
    {
        public async Task<SubscriptionResource?> Handle(GetSubscriptionDetailsQuery query)
        {
			var details =  await subscriptionService.GetSubscription(query.SubscriptionId);
			return details == null ? null : SubscriptionResource.FromSubscription(details);
        }
    }
}

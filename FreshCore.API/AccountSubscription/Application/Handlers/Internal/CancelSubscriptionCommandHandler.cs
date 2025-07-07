using FreshCore.API.AccountSubscription.Application.Commands;
using FreshCore.API.AccountSubscription.Application.Handlers.Interfaces;
using FreshCore.API.AccountSubscription.Domain.Services.Application;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Internal
{
    public class CancelSubscriptionCommandHandler(
		ISubscriptionService subscriptionService
	) : ICancelSubscriptionCommandHandler
    {
        public async Task Handle(CancelSubscriptionCommand command)
        {
			await subscriptionService.DeleteSubscription(command.SubscriptionId);
        }
    }
}

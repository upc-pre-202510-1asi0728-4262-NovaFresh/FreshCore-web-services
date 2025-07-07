using FreshCore.API.AccountSubscription.Application.Commands;
using FreshCore.API.AccountSubscription.Application.Handlers.Interfaces;
using FreshCore.API.AccountSubscription.Domain.Services.Application;
using FreshCore.API.Shared.Domain.Repositories;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Internal
{
    public class UpgradeSubscriptionCommandHandler(
		ISubscriptionService subscriptionService,
		IUnitOfWork unitOfWork
	) : IUpgradeSubscriptionCommandHandler
    {
        public async Task Handle(UpgradeSubscriptionCommand command)
        {
			await subscriptionService.UpdateSubscriptionTier(command.SubscriptionId, command.NewTierId);
			await unitOfWork.CompleteAsync();
        }
    }
}

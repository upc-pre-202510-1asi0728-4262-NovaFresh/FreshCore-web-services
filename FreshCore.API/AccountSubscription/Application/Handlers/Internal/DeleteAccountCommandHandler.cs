using FreshCore.API.AccountSubscription.Application.Commands;
using FreshCore.API.AccountSubscription.Application.Handlers.Interfaces;
using FreshCore.API.AccountSubscription.Domain.Services.Application;
using FreshCore.API.Shared.Domain.Repositories;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Internal
{
    public class DeleteAccountCommandHandler(
		ISubscriptionService subscriptionService,
		IUnitOfWork unitOfWork
	) : IDeleteAccountCommandHandler
    {
        public async Task Handle(DeleteAccountCommand command)
        {
			var subscription = await subscriptionService.GetSubscription(command.AccountId);
			if (subscription != null)
			{
				await subscriptionService.DeleteSubscription(command.AccountId);
				await unitOfWork.CompleteAsync();
			}
        }
    }
}

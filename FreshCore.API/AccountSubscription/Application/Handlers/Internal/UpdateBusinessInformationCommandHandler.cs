using FreshCore.API.AccountSubscription.Application.Commands;
using FreshCore.API.AccountSubscription.Application.Handlers.Interfaces;
using FreshCore.API.AccountSubscription.Domain.Services.Application;
using FreshCore.API.Shared.Domain.Repositories;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Internal
{
    public class UpdateBusinessInformationCommandHandler(
		IAccountService accountService,
		IUnitOfWork unitOfWork
	) : IUpdateBusinessInformationCommandHandler
    {
        public async Task Handle(UpdateBusinessInformationCommand command)
        {
			await accountService.UpdateAccountBusinessInformation(command.AccountId, command.BusinessName, command.BusinessId);
			await unitOfWork.CompleteAsync();
		}
    }
}

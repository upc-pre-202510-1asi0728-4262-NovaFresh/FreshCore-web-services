using FreshCore.API.AccountSubscription.Application.Commands;
using FreshCore.API.AccountSubscription.Application.Handlers.Interfaces;
using FreshCore.API.AccountSubscription.Domain.Services.Application;
using FreshCore.API.Shared.Domain.Repositories;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Internal
{
    public class UpdateAccountCommandHandler(
		IAccountService accountService,
		IUnitOfWork unitOfWork
	) : IUpdateAccountCommandHandler
    {
        public async Task Handle(UpdateAccountCommand command)
        {
			await accountService.UpdateAccountRepresentative(command.AccountId, command.RepresentativeId);
			await unitOfWork.CompleteAsync();
        }
    }
}

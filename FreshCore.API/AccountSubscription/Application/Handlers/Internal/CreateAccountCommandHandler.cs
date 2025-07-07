using FreshCore.API.AccountSubscription.Application.Commands;
using FreshCore.API.AccountSubscription.Application.Handlers.Interfaces;
using FreshCore.API.AccountSubscription.Application.Resources;
using FreshCore.API.AccountSubscription.Domain.Services.Application;
using FreshCore.API.Shared.Domain.Repositories;
using FreshCore.API.UserProfile.Application.Commands;
using FreshCore.API.UserProfile.Application.Handlers.Interfaces;
using FreshCore.API.UserProfile.Domain.Services.Application;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Internal
{
    public class CreateAccountCommandHandler(
		IAccountService accountService,
		ISubscriptionService subscriptionService,
		IUnitOfWork unitOfWork,
		IProfileService profileService,
		IGrantPrivilegeCommandHandler grantPrivilegeCommandHandler
	) : ICreateAccountCommandHandler
    {
        public async Task<AccountResource> Handle(CreateAccountCommand command)
        {
			var result = await accountService.CreateAccount(command.RepresentativeId, command.BusinessName, command.BusinessId);
			await unitOfWork.CompleteAsync();
			await subscriptionService.CreateSubscription(result.Id);
			var profile = await profileService.GetProfile(result.RepresentativeId);
			profile!.AccountId = result.Id;
			await profileService.UpdateProfile(profile);
			
			var grantPrivilegeCommands = new List<GrantPrivilegeCommand>
			{
				new(result.RepresentativeId, 0),
				new(result.RepresentativeId, 1),
				new(result.RepresentativeId, 2)
			};

			foreach (var grantPrivilegeCommand in grantPrivilegeCommands)
			{
				await grantPrivilegeCommandHandler.Handle(grantPrivilegeCommand);
			}
			
			await unitOfWork.CompleteAsync();
			return AccountResource.FromAccount(result);
        }
    }
}

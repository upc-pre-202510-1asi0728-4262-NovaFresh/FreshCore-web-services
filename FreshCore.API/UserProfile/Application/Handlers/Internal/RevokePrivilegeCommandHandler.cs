using FreshCore.API.Shared.Domain.Repositories;
using FreshCore.API.UserProfile.Application.Commands;
using FreshCore.API.UserProfile.Application.Handlers.Interfaces;
using FreshCore.API.UserProfile.Domain.Models.ValueObjects;
using FreshCore.API.UserProfile.Domain.Services.Application;

namespace FreshCore.API.UserProfile.Application.Handlers.Internal
{
    public class RevokePrivilegeCommandHandler(
        IProfileService profileService,
        IUnitOfWork unitOfWork
        ) : IRevokePrivilegeCommandHandler
    {
        public async Task Handle(RevokePrivilegeCommand command)
        {
            var profilePrivilege = new ProfilePrivilege(command.ProfileId, (Privilege)command.PrivilegeId);
            await profileService.RevokePrivilege(profilePrivilege);
            await unitOfWork.CompleteAsync();
        }
    }
}

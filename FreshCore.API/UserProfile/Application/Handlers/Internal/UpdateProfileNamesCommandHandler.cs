using FreshCore.API.Shared.Domain.Repositories;
using FreshCore.API.UserProfile.Application.Commands;
using FreshCore.API.UserProfile.Application.Handlers.Interfaces;
using FreshCore.API.UserProfile.Domain.Services.Application;

namespace FreshCore.API.UserProfile.Application.Handlers.Internal
{
    public class UpdateProfileNamesCommandHandler(
        IProfileService profileService,
        IUnitOfWork unitOfWork
        ) : IUpdateProfileNamesCommandHandler
    {
        public async Task Handle(UpdateProfileNamesCommand command)
        {
            var profile = await profileService.GetProfile(command.ProfileId);
            if (profile != null)
            {
                profile.FirstName = command.FirstName;
                profile.LastName = command.LastName;
                await profileService.UpdateProfile(profile);
                await unitOfWork.CompleteAsync();
            }
        }
    }
}

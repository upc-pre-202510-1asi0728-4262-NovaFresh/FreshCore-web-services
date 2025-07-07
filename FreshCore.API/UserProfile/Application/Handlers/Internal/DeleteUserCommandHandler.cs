using FreshCore.API.Shared.Domain.Repositories;
using FreshCore.API.UserProfile.Application.Commands;
using FreshCore.API.UserProfile.Application.Handlers.Interfaces;
using FreshCore.API.UserProfile.Domain.Services.Application;

namespace FreshCore.API.UserProfile.Application.Handlers.Internal
{
    public class DeleteUserCommandHandler(
        IUserService userService,
        IProfileService profileService,
        IUnitOfWork unitOfWork
        ) : IDeleteUserCommandHandler
    {
        public async Task Handle(DeleteUserCommand command)
        {
            await userService.DeleteUser(command.UserId);
            var profile = await profileService.GetProfile(command.UserId);
            await profileService.DeleteProfile(profile!.Id);
            await unitOfWork.CompleteAsync();
        }
    }
}

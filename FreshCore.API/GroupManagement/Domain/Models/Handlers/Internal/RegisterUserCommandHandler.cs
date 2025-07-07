using FreshCore.API.GroupManagement.Domain.Models.Commands;
using FreshCore.API.Shared.Domain.Repositories;
using FreshCore.API.UserProfile.Domain.Services.Application;


namespace FreshCore.API.GroupManagement.Domain.Models.Handlers.Internal
{
    public class RegisterUserCommandHandler (
        IUserService userService,
        IUnitOfWork unitOfWork,
        IProfileService profileService
    ) : IRegisterUserCommandHandler
    {
    public async Task Handle(RegisterUserCommand command)
     {
        var user = await userService.GetUserByEmail(command.Email);
        if (user == null)
        {
            throw new Exception("User not found");
        }
        var profile = await profileService.GetProfile(user.Id);
        if (profile == null)
        {
            throw new Exception("Profile not found");
        }
        profile.AccountId = command.AccountId;
        profile.GroupId = command.GroupId;
        await unitOfWork.CompleteAsync();

     }
    }
}
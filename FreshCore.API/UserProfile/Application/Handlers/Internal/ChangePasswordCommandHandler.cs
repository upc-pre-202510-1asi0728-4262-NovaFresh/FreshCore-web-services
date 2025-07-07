using FreshCore.API.Shared.Domain.Repositories;
using FreshCore.API.UserProfile.Application.Commands;
using FreshCore.API.UserProfile.Application.Handlers.Interfaces;
using FreshCore.API.UserProfile.Domain.Services.Application;

namespace FreshCore.API.UserProfile.Application.Handlers.Internal
{
    public class ChangePasswordCommandHandler(
        IUserService userService,
        IUnitOfWork unitOfWork
        ) : IChangePasswordCommandHandler
    {
        public async Task Handle(ChangePasswordCommand command)
        {
            var user = await userService.GetUser(command.UserId);
            user!.Password = userService.EncryptPassword(command.NewPassword);
            await userService.UpdateUser(user);
            await unitOfWork.CompleteAsync();
        }
    }
}

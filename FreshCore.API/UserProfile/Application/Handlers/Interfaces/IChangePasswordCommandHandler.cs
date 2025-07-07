using FreshCore.API.UserProfile.Application.Commands;

namespace FreshCore.API.UserProfile.Application.Handlers.Interfaces
{
    public interface IChangePasswordCommandHandler
    {
        public Task Handle(ChangePasswordCommand command);
    }
}

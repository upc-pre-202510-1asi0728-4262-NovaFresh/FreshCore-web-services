using FreshCore.API.UserProfile.Application.Commands;

namespace FreshCore.API.UserProfile.Application.Handlers.Interfaces
{
    public interface IDeleteUserCommandHandler
    {
        public Task Handle(DeleteUserCommand command);
    }
}

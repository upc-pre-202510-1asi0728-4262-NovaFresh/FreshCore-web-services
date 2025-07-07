using FreshCore.API.UserProfile.Application.Commands;

namespace FreshCore.API.UserProfile.Application.Handlers.Interfaces
{
    public interface IGrantPrivilegeCommandHandler
    {
        public Task Handle(GrantPrivilegeCommand command);
    }
}

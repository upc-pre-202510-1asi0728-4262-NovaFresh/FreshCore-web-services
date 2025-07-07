using FreshCore.API.UserProfile.Application.Commands;

namespace FreshCore.API.UserProfile.Application.Handlers.Interfaces
{
    public interface IRevokePrivilegeCommandHandler
    {
        public Task Handle(RevokePrivilegeCommand command);
    }
}

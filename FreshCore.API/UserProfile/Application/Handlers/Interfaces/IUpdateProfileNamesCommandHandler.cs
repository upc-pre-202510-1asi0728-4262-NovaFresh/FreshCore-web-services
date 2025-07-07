using FreshCore.API.UserProfile.Application.Commands;

namespace FreshCore.API.UserProfile.Application.Handlers.Interfaces
{
    public interface IUpdateProfileNamesCommandHandler
    {
        public Task Handle(UpdateProfileNamesCommand command);
    }
}

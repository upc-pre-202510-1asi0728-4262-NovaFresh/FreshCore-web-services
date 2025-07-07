using FreshCore.API.UserProfile.Application.Commands;
using FreshCore.API.UserProfile.Application.Resources;

namespace FreshCore.API.UserProfile.Application.Handlers.Interfaces
{
    public interface ILoginCommandHandler
    {
        public Task<LoginResource?> Handle(LoginCommand command);
    }
}

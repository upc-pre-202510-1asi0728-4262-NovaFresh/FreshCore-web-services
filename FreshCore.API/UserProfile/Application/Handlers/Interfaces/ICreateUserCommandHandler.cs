using FreshCore.API.UserProfile.Application.Commands;
using FreshCore.API.UserProfile.Application.Resources;

namespace FreshCore.API.UserProfile.Application.Handlers.Interfaces
{
	public interface ICreateUserCommandHandler
	{
		public Task<UserResource> Handle(CreateUserCommand command);
	}
}
using FreshCore.API.UserProfile.Application.Commands;
using FreshCore.API.UserProfile.Application.Handlers.Interfaces;
using FreshCore.API.UserProfile.Application.Resources;
using FreshCore.API.UserProfile.Domain.Services.Application;

namespace FreshCore.API.UserProfile.Application.Handlers.Internal
{
	public class LoginCommandHandler(
		IUserService userService,
		IProfileService profileService
	) : ILoginCommandHandler
	{
		public async Task<LoginResource?> Handle(LoginCommand command)
		{
			var user = await userService.GetUserByEmail(command.Email) ?? null;
			var token = await userService.Login(command.Email, command.Password) ?? null;
			if (user == null || token == null)
			{
				return null;
			}

			var profile = await profileService.GetProfile(user.Id) ?? null;
			var privileges = await profileService.ListUserPrivileges(user.Id) ?? null;

			int? accountId = null;
			int? groupId = null;
			if (profile != null)
			{
				accountId = profile.AccountId;
				groupId = profile.GroupId;
			}


			return new LoginResource()
			{
				UserId = user.Id,
				Username = user.Username,
				Token = token,
				AccountId = accountId,
				GroupId = groupId,
				ProfileId = user.Id,
				Privileges = privileges == null ? [] : privileges.Select(p => p.ToString()).ToArray()
			};

		}
	}
}

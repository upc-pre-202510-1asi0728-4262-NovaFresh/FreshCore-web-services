using FreshCore.API.UserProfile.Application.Resources;
using FreshCore.API.UserProfile.Application.Handlers.Interfaces;
using FreshCore.API.UserProfile.Application.Queries;
using FreshCore.API.UserProfile.Domain.Services.Application;

namespace FreshCore.API.UserProfile.Application.Handlers.Internal
{
    public class GetUserQueryHandler(
        IUserService userService
        ) : IGetUserQueryHandler
    {
        public async Task<UserResource?> Handle(GetUserQuery query)
        {
            var result = await userService.GetUser(query.UserId);
            return result == null ? null : UserResource.FromUser(result);
        }
    }
}

using FreshCore.API.AccountSubscription.Application.Queries;
using FreshCore.API.UserProfile.Application.Resources;
using FreshCore.API.UserProfile.Domain.Services.Application;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Internal
{
    public class GetUsersByAccountIdQueryHandler(
        IProfileService profileService
    ) : IGetUsersByAccountIdQueryHandler
    {
        public async Task<IEnumerable<ProfileResource>> Handle(GetUsersByAccountIdQuery query)
        {
            var result = await profileService.GetProfilesByAccountId(query.AccountId);
            return result.Select(ProfileResource.FromProfile);
        }
    }
}
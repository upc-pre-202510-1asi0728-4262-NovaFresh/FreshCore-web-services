using FreshCore.API.UserProfile.Application.Handlers.Interfaces;
using FreshCore.API.UserProfile.Application.Queries;
using FreshCore.API.UserProfile.Application.Resources;
using FreshCore.API.UserProfile.Domain.Repositories;
using FreshCore.API.UserProfile.Domain.Services.Application;

namespace FreshCore.API.UserProfile.Application.Handlers.Internal
{
    public class GetProfileDetailsQueryHandler(
        IProfileService profileService
        ) : IGetProfileDetailsQueryHandler
    {
        public async Task<ProfileResource?> Handle(GetProfileQuery query)
        {
            var result = await profileService.GetProfile(query.ProfileId);
            if (result == null)
            {
                return null;
            }
            var privileges = await profileService.ListUserPrivileges(query.ProfileId);
            return new ProfileResource()
            {
                AccountId = result.AccountId,
                GroupId = result.GroupId,
                FirstName = result.FirstName,
                LastName = result.LastName,
                Privileges = privileges.Select(p => p.ToString()).ToArray()
            };
        }
    }
}

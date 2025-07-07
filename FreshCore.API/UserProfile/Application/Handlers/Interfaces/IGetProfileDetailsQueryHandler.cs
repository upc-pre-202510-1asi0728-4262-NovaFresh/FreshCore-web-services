using FreshCore.API.UserProfile.Application.Queries;
using FreshCore.API.UserProfile.Application.Resources;

namespace FreshCore.API.UserProfile.Application.Handlers.Interfaces
{
    public interface IGetProfileDetailsQueryHandler
    {
        public Task<ProfileResource?> Handle(GetProfileQuery query);
    }
}

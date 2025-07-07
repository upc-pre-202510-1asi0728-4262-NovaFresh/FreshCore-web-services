using FreshCore.API.Shared.Domain.Repositories;
using FreshCore.API.UserProfile.Domain.Models.ValueObjects;

namespace FreshCore.API.UserProfile.Domain.Repositories
{
    public interface IProfilePrivilegeRepository : IBaseRepository<ProfilePrivilege>
    {
        public Task<bool> SamePrivilegeExists(ProfilePrivilege profilePrivilege);
        public Task<ICollection<ProfilePrivilege>> GetAllByProfileId(int profileId);
    }
}

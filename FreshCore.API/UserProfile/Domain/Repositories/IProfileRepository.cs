using FreshCore.API.Shared.Domain.Repositories;
using FreshCore.API.UserProfile.Domain.Models.Entities;

namespace FreshCore.API.UserProfile.Domain.Repositories {
    public interface IProfileRepository : IBaseRepository<Profile>
    {
        public Task<IEnumerable<Profile>> GetByAccountId(int accountId);
    }
}
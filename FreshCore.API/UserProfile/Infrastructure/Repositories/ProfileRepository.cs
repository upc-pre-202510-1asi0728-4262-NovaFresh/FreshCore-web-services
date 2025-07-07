using FreshCore.API.Shared.Infrastructure;
using FreshCore.API.Shared.Infrastructure.Repositories;
using FreshCore.API.UserProfile.Domain.Models.Entities;
using FreshCore.API.UserProfile.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FreshCore.API.UserProfile.Infrastructure.Repositories
{
    public class ProfileRepository : BaseRepository<Profile>, IProfileRepository
    {
        private readonly ApplicationDbContext _context;

        public ProfileRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Profile>> GetByAccountId(int accountId)
        {
            return await _context.Profiles.Where(p => p.AccountId == accountId).Include(p => p.ProfilePrivileges).ToListAsync();
        }
    }
}

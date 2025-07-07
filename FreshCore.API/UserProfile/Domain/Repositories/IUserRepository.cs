using FreshCore.API.Shared.Domain.Repositories;
using FreshCore.API.UserProfile.Domain.Models.Entities;

namespace FreshCore.API.UserProfile.Domain.Repositories {
	public interface IUserRepository : IBaseRepository<User> {
		public Task<User?> GetByEmail(string email);
		public Task<User?> GetByUsername(string username);
    }
}
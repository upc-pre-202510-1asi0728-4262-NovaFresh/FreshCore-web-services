using FreshCore.API.GroupManagement.Domain.Models.ValueObject;
using FreshCore.API.GroupManagement.Domain.Repositories;
using FreshCore.API.Shared.Infrastructure;
using FreshCore.API.Shared.Infrastructure.Repositories;

namespace FreshCore.API.GroupManagement.Infrastructure.Repositories
{
    public class UserRegistrationRepositories : BaseRepository<UserRegistration>, IUserRegistrationRepository
    {
        public UserRegistrationRepositories(ApplicationDbContext context) : base(context)
        {
        }
    }
}

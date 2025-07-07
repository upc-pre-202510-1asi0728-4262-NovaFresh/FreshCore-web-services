using FreshCore.API.ContainerManagement.Domain.Models.Entities;
using FreshCore.API.Shared.Domain.Repositories;

namespace FreshCore.API.ContainerManagement.Domain.Repositories
{
    public interface IContainerRepository : IBaseRepository<Container>
    {
        public Task<IEnumerable<Container>> GetContainersByGroupId(int groupId);
        public Task<IEnumerable<Container>> GetContainersByAccountId(int accountId);
		public Task<Container?> GetContainerByUuid(string uuid);
    }
}

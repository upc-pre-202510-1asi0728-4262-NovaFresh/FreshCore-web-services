using FreshCore.API.GroupManagement.Domain.Models.Entities;
using FreshCore.API.Shared.Domain.Repositories;


namespace FreshCore.API.GroupManagement.Domain.Repositories
{
    public interface IGroupRepository : IBaseRepository<Group>
    {
        public Task<IEnumerable<int>> GetProfileCountByGroupId(int groupId);
        public Task<IEnumerable<int>> GetContainerCountByGroupId(int groupId);
    }
}

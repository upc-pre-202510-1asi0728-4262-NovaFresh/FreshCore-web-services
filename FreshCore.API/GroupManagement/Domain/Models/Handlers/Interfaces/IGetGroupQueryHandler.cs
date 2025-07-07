using FreshCore.API.GroupManagement.Domain.Models.Queries;
using FreshCore.API.GroupManagement.Domain.Models.Resources;
using FreshCore.API.GroupManagement.Domain.Repositories;

namespace FreshCore.API.GroupManagement.Domain.Models.Handlers.Internal
{
    public interface IGetGroupQueryHandler
    {
        public Task<GroupResource?> Handle(GetGroupQuery query);
    }
}
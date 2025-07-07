using FreshCore.API.AccountSubscription.Application.Handlers.Interfaces;
using FreshCore.API.AccountSubscription.Application.Queries;
using FreshCore.API.AccountSubscription.Domain.Services.Application;
using FreshCore.API.GroupManagement.Domain.Models.Resources;
using FreshCore.API.GroupManagement.Domain.Services.Application;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Internal
{
    public class GetGroupsByAccountIdQueryHandler (
        IGroupService groupService
    ): IGetGroupsByAccountIdQueryHandler
    {
        public async Task<IEnumerable<GroupResource>> Handle(GetGroupsByAccountIdQuery query)
        {
            var result = await groupService.GetGroupsByAccountId(query.AccountId);
            return result.Select(GroupResource.FromGroup);
        }
    }
}
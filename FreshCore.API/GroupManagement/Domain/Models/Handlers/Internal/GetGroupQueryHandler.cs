using FreshCore.API.GroupManagement.Domain.Models.Queries;
using FreshCore.API.GroupManagement.Domain.Models.Resources;
using FreshCore.API.GroupManagement.Domain.Repositories;
using FreshCore.API.GroupManagement.Domain.Services.Application;

namespace FreshCore.API.GroupManagement.Domain.Models.Handlers.Internal
{
    public class GetGroupQueryHandler (
        IGroupService groupService
        ) : IGetGroupQueryHandler
        
        {
        public async Task<GroupResource?> Handle(GetGroupQuery query){

            var group = await groupService.GetGroup(query.GroupId);
            if(group == null){
                return null;
            }
            return GroupResource.FromGroup(group);
        }
    }

}
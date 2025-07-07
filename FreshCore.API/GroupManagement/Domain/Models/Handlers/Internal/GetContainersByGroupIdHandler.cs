using FreshCore.API.ContainerManagement.Domain.Services.Application;
using FreshCore.API.ContainerManagement.Interface.Resources;
using FreshCore.API.GroupManagement.Domain.Models.Queries;

namespace FreshCore.API.GroupManagement.Domain.Models.Handlers.Interfaces
{
    public class GetContainersByGroupIdQueryHandler (
        IContainerService containerService
    ) : IGetContainersByGroupIdQueryHandler
    {
        public async Task<IEnumerable<ContainerResource>> Handle(GetContainersByGroupIdQuery query)
        {
            var containers = await containerService.GetContainersByGroupId(query.GroupId);
            return containers.Select(ContainerResource.FromContainer);
        }
    }
    
}
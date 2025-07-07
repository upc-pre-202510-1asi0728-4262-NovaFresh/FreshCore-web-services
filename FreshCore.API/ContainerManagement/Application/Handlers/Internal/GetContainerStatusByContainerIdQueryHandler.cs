using FreshCore.API.ContainerManagement.Application.Handlers.Interfaces;
using FreshCore.API.ContainerManagement.Application.Queries;
using FreshCore.API.ContainerManagement.Domain.Services.Application;
using FreshCore.API.ContainerManagement.Interface.Resources;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Internal
{
    public class GetContainerStatusByContainerIdQueryHandler(
        IContainerService containerService
        ) : IGetContainerStatusByContainerIdQueryHandler
    {
        public async Task<ContainerStatusResource?> Handle(GetContainerStatusByContainerIdQuery query)
        {
            var result = await containerService.GetContainerById(query.ContainerId);
            return result == null ? null : ContainerStatusResource.FromContainer(result);
        }
    }
}

using FreshCore.API.AccountSubscription.Application.Handlers.Interfaces;
using FreshCore.API.ContainerManagement.Application.Handlers.Interfaces;
using FreshCore.API.ContainerManagement.Application.Queries;
using FreshCore.API.ContainerManagement.Domain.Services.Application;
using FreshCore.API.ContainerManagement.Interface.Resources;
using FreshCore.API.Shared.Domain.Repositories;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Internal
{
    public class GetContainerQueryHandler(
        IContainerService containerService
        ) : IGetContainerQueryHandler
    {
        public async Task<ContainerResource?> Handle(GetContainerByIdQuery query)
        {
            var result = await containerService.GetContainerById(query.ContainerId);

            return result == null ? null : ContainerResource.FromContainer(result);
        }
    }
}

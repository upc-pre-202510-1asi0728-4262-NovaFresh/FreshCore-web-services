using FreshCore.API.ContainerManagement.Application.Handlers.Interfaces;
using FreshCore.API.ContainerManagement.Application.Queries;
using FreshCore.API.ContainerManagement.Domain.Services.Application;
using FreshCore.API.ContainerManagement.Interface.Resources;
using FreshCore.API.Shared.Domain.Repositories;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Internal {
	class GetContainersQueryHandler(
		IContainerService containerService
	) : IGetContainersQueryHandler {
		public async Task<IEnumerable<ContainerResource>> Handle(GetContainersQuery query) {
			var containers = await containerService.GetContainers();
			return containers.Select(ContainerResource.FromContainer);
		}
	}
}
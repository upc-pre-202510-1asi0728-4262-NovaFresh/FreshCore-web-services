using FreshCore.API.ContainerManagement.Application.Queries;
using FreshCore.API.ContainerManagement.Interface.Resources;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Interfaces
{
    public interface IGetContainerStatusByContainerIdQueryHandler
    {
        public Task<ContainerStatusResource?> Handle(GetContainerStatusByContainerIdQuery query);
    }
}

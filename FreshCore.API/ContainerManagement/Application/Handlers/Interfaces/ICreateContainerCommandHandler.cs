using FreshCore.API.ContainerManagement.Application.Commands;
using FreshCore.API.ContainerManagement.Interface.Resources;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Interfaces
{
    public interface ICreateContainerCommandHandler
    {
        public Task<CreateContainerResource> Handle(CreateContainerCommand command);
    }
}

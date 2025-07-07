using FreshCore.API.ContainerManagement.Application.Commands;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Interfaces
{
    public interface IUpdateContainerStatusCommandHandler
    {
        public Task Handle(int containerId, UpdateContainerStatusCommand command);
    }
}

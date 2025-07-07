using FreshCore.API.ContainerManagement.Application.Commands;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Interfaces
{
    public interface IUpdateContainerParametersCommandHandler
    {
        public Task Handle(int containerId, UpdateContainerParametersCommand command);
    }
}

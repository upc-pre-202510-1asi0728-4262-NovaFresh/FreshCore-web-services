using FreshCore.API.ContainerManagement.Application.Commands;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Interfaces
{
    public interface IUpdateContainerMetricsCommandHandler
    {
        public Task Handle(int containerId, UpdateContainerMetricsCommand command);
    }
}

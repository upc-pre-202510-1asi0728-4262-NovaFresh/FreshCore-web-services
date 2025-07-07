using FreshCore.API.ContainerManagement.Application.Commands;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Interfaces
{
    public interface IUpdateHealthStatusCommandHandler
    {
        public Task Handle(int containerId, UpdateHealthStatusCommand command);
    }
}

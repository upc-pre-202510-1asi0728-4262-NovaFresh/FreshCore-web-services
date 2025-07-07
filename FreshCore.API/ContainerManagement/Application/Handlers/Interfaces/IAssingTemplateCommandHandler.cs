using FreshCore.API.ContainerManagement.Application.Commands;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Interfaces
{
    public interface IAssingTemplateCommandHandler
    {
        Task Handle(AssingTemplateCommand command);
    }
}
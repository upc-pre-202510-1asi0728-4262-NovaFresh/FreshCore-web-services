using FreshCore.API.ContainerManagement.Application.Commands;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Interfaces
{
    public interface IUpdateTemplateCommandHandler
    {
        public Task Handle(UpdateTemplateCommand command);
    }
}
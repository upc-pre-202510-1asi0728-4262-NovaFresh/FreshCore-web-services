using FreshCore.API.ContainerManagement.Application.Commands;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Interfaces
{
    public interface IDeleteTemplateCommandHandler
    {
        public Task Handle(DeleteTemplateCommand command);
    }
}
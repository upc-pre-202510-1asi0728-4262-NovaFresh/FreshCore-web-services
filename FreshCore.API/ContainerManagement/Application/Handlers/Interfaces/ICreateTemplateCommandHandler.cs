using FreshCore.API.ContainerManagement.Application.Commands;
using FreshCore.API.ContainerManagement.Interface.Resources;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Interfaces
{
    public interface ICreateTemplateCommandHandler
    {
        public Task<TemplateResource> Handle(CreateTemplateCommand command);
    }
}
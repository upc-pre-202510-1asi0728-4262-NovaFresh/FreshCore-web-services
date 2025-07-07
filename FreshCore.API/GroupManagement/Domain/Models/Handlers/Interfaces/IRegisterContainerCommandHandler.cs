using FreshCore.API.ContainerManagement.Interface.Resources;
using FreshCore.API.GroupManagement.Domain.Models.Commands;

namespace FreshCore.API.GroupManagement.Domain.Models.Handlers.Interfaces
{
    public interface IRegisterContainerCommandHandler
    {
        public Task<ContainerRegistrationResource> Handle(RegisterContainerCommand command);
    }
}
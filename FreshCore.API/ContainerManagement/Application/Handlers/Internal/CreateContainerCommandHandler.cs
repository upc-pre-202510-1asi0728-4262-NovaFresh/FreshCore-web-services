using FreshCore.API.ContainerManagement.Application.Commands;
using FreshCore.API.ContainerManagement.Application.Handlers.Interfaces;
using FreshCore.API.ContainerManagement.Domain.Models.ValueObjects;
using FreshCore.API.ContainerManagement.Domain.Services.Application;
using FreshCore.API.ContainerManagement.Interface.Resources;
using FreshCore.API.Shared.Domain.Repositories;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Internal
{
    public class CreateContainerCommandHandler(
        IContainerService containerService,
        IUnitOfWork unitOfWork,
        INotificationService notificationService
        ) : ICreateContainerCommandHandler
    {
        public async Task<CreateContainerResource> Handle(CreateContainerCommand command)
        {
            var result = await containerService.CreateContainer(command.DeviceId, command.Name, command.Description, command.AccountId, command.GroupId);
            await unitOfWork.CompleteAsync();
            await notificationService.GenerateNotification(AlertType.ContainerLinked, containerId: result.Id, accountId: command.AccountId, groupId: command.GroupId);
            return CreateContainerResource.FromContainer(result);
        }
    }
}

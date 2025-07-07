using FreshCore.API.ContainerManagement.Application.Commands;
using FreshCore.API.ContainerManagement.Application.Handlers.Interfaces;
using FreshCore.API.ContainerManagement.Domain.Models.ValueObjects;
using FreshCore.API.ContainerManagement.Domain.Services.Application;
using FreshCore.API.Shared.Domain.Repositories;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Internal
{
    public class UpdateContainerParametersCommandHandler(
        IContainerService containerService,
        IUnitOfWork unitOfWork,
        INotificationService notificationService
        ) : IUpdateContainerParametersCommandHandler
    {
        public async Task Handle(int containerId, UpdateContainerParametersCommand command)
        {
            var container = await containerService.GetContainerById(containerId);
            if (container != null)
            {
                var conditions = new ContainerConditions(
                    command.MinTemp, command.MaxTemp,
                    command.MinHumidity, command.MaxHumidity,
                    command.OxygenMin, command.OxygenMax,
                    command.DioxideMin, command.DioxideMax,
                    command.EthyleneMin, command.EthyleneMax,
                    command.AmmoniaMin, command.AmmoniaMax,
                    command.SulfurDioxideMin, command.SulfurDioxideMax
                    );
                container.UpdateConditions(conditions);
                await containerService.UpdateContainer(container);
                await unitOfWork.CompleteAsync();
                await notificationService.GenerateNotification(AlertType.ContainerActivated, containerId: container.Id, accountId: container.AccountId, groupId: container.GroupId);
				await unitOfWork.CompleteAsync();
            }
        }
    }
}

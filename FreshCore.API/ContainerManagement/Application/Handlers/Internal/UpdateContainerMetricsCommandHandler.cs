using FreshCore.API.ContainerManagement.Application.Commands;
using FreshCore.API.ContainerManagement.Application.Handlers.Interfaces;
using FreshCore.API.ContainerManagement.Domain.Models.ValueObjects;
using FreshCore.API.ContainerManagement.Domain.Services.Application;
using FreshCore.API.Shared.Domain.Repositories;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Internal
{
    public class UpdateContainerMetricsCommandHandler(
        IContainerService containerService,
        IUnitOfWork unitOfWork,
        INotificationService notificationService
        ) : IUpdateContainerMetricsCommandHandler
    {
        public async Task Handle(int containerId, UpdateContainerMetricsCommand command)
        {
            var container = await containerService.GetContainerById(containerId);
            if (container != null) 
            {
                container.UpdateMetrics(command.Temperature, command.Humidity, command.Oxygen, command.Dioxide, command.Ethylene, command.Ammonia, command.SulfurDioxide);
                await containerService.UpdateContainer(container);
                await unitOfWork.CompleteAsync();
                await notificationService.GenerateNotification(AlertType.ContainerStatusReport, containerId: container.Id, accountId: container.AccountId, groupId: container.GroupId);
				await unitOfWork.CompleteAsync();

				if (!container.IsTemperatureWithinRange())
				{
					await notificationService.GenerateNotification(AlertType.TemperatureThresholdExceeded, containerId: container.Id, accountId: container.AccountId, groupId: container.GroupId);
					await unitOfWork.CompleteAsync();
				}
				if (!container.IsHumidityWithinRange())
				{
					await notificationService.GenerateNotification(AlertType.HumidityThresholdExceeded, containerId: container.Id, accountId: container.AccountId, groupId: container.GroupId);
					await unitOfWork.CompleteAsync();
				}                
            }


        }
    }
}

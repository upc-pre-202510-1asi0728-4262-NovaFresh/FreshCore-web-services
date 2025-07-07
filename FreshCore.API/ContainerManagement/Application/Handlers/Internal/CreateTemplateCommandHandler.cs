using FreshCore.API.ContainerManagement.Application.Commands;
using FreshCore.API.ContainerManagement.Application.Handlers.Interfaces;
using FreshCore.API.ContainerManagement.Domain.Services.Application;
using FreshCore.API.ContainerManagement.Interface.Resources;
using FreshCore.API.Shared.Domain.Repositories;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Internal {
	public class CreateTemplateCommandHandler(
		ITemplateService templateService,
		IUnitOfWork unitOfWork
	) : ICreateTemplateCommandHandler {
		public async Task<TemplateResource> Handle(CreateTemplateCommand command) {
			var template = await templateService.CreateTemplate(
				command.Name,
				command.MaxTemperatureThreshold,
				command.MinTemperatureThreshold,
				command.MaxHumidityThreshold,
				command.MinHumidityThreshold,
				command.MaxOxygenThreshold,
				command.MinCarbonDioxideThreshold,
				command.MaxCarbonDioxideThreshold,
				command.MinOxygenThreshold,
				command.MinSulfurDioxideThreshold,
				command.MaxSulfurDioxideThreshold,
				command.MinEthyleneThreshold,
				command.MaxEthyleneThreshold,
				command.MinAmmoniaThreshold,
				command.MaxAmmoniaThreshold,
				command.Category
			);

			await unitOfWork.CompleteAsync();

			return TemplateResource.FromTemplate(template);
		}
	}
}
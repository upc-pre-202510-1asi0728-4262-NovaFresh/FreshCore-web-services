using FreshCore.API.ContainerManagement.Domain.Models.Entities;
using FreshCore.API.ContainerManagement.Domain.Models.ValueObjects;
using FreshCore.API.ContainerManagement.Domain.Repositories;
using FreshCore.API.ContainerManagement.Domain.Services.Application;
using FreshCore.API.Shared.Domain.Repositories;

namespace FreshCore.API.ContainerManagement.Application.Services
{
	class TemplateService(ITemplateRepository templateRepository, IUnitOfWork unitOfWork) : ITemplateService
	{

		public async Task<Template> CreateTemplate(string name, double maxTemperatureThreshold, double minTemperatureThreshold, double maxHumidityThreshold, double minHumidityThreshold, double? maxOxygenThreshold, double? minCarbonDioxideThreshold, double? maxCarbonDioxideThreshold, double? minOxygenThreshold, double? minSulfurDioxideThreshold, double? maxSulfurDioxideThreshold, double? minEthyleneThreshold, double? maxEthyleneThreshold, double? minAmmoniaThreshold, double? maxAmmoniaThreshold, TemplateCategory category)
		{
			var template = new Template(
				name,
				maxTemperatureThreshold,
				minTemperatureThreshold,
				maxHumidityThreshold,
				minHumidityThreshold,
				maxOxygenThreshold,
				minCarbonDioxideThreshold,
				maxCarbonDioxideThreshold,
				minOxygenThreshold,
				minSulfurDioxideThreshold,
				maxSulfurDioxideThreshold,
				minEthyleneThreshold,
				maxEthyleneThreshold,
				minAmmoniaThreshold,
				maxAmmoniaThreshold,
				category
			);

			await templateRepository.Add(template);
			await unitOfWork.CompleteAsync();
			return template;
		}

		public async Task<Template?> GetTemplate(int templateId)
		{
			return await templateRepository.GetById(templateId);
		}

		public async Task<IEnumerable<Template>> GetTemplates()
		{
			return await templateRepository.GetAll();
		}
	}
}
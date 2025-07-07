using System.ComponentModel.DataAnnotations;
using FreshCore.API.ContainerManagement.Domain.Models.ValueObjects;

namespace FreshCore.API.ContainerManagement.Application.Commands
{
    public record CreateTemplateCommand(
        [Required] string Name,
        [Required] double MaxTemperatureThreshold,
        [Required] double MinTemperatureThreshold,
        [Required] double MaxHumidityThreshold,
        [Required] double MinHumidityThreshold,
        [Required] double? MaxOxygenThreshold,
        [Required] double? MinOxygenThreshold,
        [Required] double? MaxCarbonDioxideThreshold,
        [Required] double? MinCarbonDioxideThreshold,
        [Required] double? MinSulfurDioxideThreshold,
        [Required] double? MaxSulfurDioxideThreshold,
        [Required] double? MinEthyleneThreshold,
        [Required] double? MaxEthyleneThreshold,
        [Required] double? MinAmmoniaThreshold,
        [Required] double? MaxAmmoniaThreshold,
        [Required] TemplateCategory Category
    );
}
using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.ContainerManagement.Application.Commands
{
    public record UpdateContainerMetricsCommand (
        [Required]double Temperature,
        [Required]double Humidity,
        [Required]double Oxygen,
        [Required]double Dioxide,
        [Required]double Ethylene,
        [Required]double Ammonia,
        [Required]double SulfurDioxide
    );
}

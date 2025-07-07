using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.ContainerManagement.Application.Commands
{
    public record CreateContainerCommand(
		[Required] string DeviceId,
        [Required] string Name,
        [Required] string Description,
        [Required] int AccountId,
        [Required] int GroupId
    );
}
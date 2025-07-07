using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.ContainerManagement.Application.Commands
{
    public record AssingTemplateCommand(
        [Required] int ContainerId,
        [Required] int TemplateId
    );
}
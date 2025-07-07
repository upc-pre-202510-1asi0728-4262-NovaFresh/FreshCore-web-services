using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.ContainerManagement.Application.Commands
{
    public record DeleteTemplateCommand
    (
        [Required] int TemplateId
    );
}
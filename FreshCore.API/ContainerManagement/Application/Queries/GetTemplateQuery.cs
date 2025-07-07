using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.ContainerManagement.Application.Queries
{
    public record GetTemplateQuery(
        [Required] int TemplateId
        );
}
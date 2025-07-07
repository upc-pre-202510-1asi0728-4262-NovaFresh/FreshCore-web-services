using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.GroupManagement.Domain.Models.Commands
{
    public record RegisterContainerCommand(
        [Required] string Uiid
    );
}
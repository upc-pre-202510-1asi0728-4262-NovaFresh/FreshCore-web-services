using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.GroupManagement.Domain.Models.Commands
{
    public record RegisterUserCommand(
        [Required] string Email,
        [Required] int AccountId,
        [Required] int GroupId
    );
}
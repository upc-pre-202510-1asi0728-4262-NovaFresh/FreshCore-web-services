using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.UserProfile.Application.Commands
{
    public record DeleteUserCommand
        (
        [Required] int UserId
        );
}
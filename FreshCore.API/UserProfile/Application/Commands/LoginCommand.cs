using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.UserProfile.Application.Commands
{
    public record LoginCommand(
        [Required, EmailAddress] string Email,
        [Required] string Password
    );
}

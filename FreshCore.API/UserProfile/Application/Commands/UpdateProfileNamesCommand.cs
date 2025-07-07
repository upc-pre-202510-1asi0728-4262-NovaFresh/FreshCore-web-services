using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.UserProfile.Application.Commands
{
    public record UpdateProfileNamesCommand(
        [Required, Range(1, int.MaxValue)] int ProfileId,
        [Required, StringLength(64)] string FirstName,
        [Required, StringLength(64)] string LastName
        );
}
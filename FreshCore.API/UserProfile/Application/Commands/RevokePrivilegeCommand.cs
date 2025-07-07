using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.UserProfile.Application.Commands
{
    public record RevokePrivilegeCommand
    (
        [Required, Range(1, int.MaxValue)] int ProfileId,
        [Required] int PrivilegeId
        );
}
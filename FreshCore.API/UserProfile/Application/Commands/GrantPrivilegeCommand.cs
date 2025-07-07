using FreshCore.API.UserProfile.Domain.Models.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.UserProfile.Application.Commands
{
    public record GrantPrivilegeCommand
    (
        [Required, Range(1, int.MaxValue)] int ProfileId,
        [Required] int PrivilegeId
    );
}
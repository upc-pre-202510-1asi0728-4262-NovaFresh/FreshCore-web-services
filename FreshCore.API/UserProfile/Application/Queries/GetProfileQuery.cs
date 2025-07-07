using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.UserProfile.Application.Queries
{
    public record GetProfileQuery(
        [Required, Range(1, int.MaxValue)] int ProfileId
    );
}
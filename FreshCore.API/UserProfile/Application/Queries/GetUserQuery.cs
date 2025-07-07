using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.UserProfile.Application.Queries
{
    public record GetUserQuery (
        [Required] int UserId
    );
}
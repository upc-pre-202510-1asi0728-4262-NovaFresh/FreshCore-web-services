using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.AccountSubscription.Application.Queries
{
    public record GetUsersByAccountIdQuery(
        [Required] int AccountId
    );
}
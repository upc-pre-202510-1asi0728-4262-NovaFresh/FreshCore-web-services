using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.AccountSubscription.Application.Queries
{
    public record GetGroupsByAccountIdQuery(
        [Required] int AccountId
    );
}
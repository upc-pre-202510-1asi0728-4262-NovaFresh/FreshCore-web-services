using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.AccountSubscription.Application.Queries
{
    public record GetSubscriptionDetailsQuery
    (
        [Required] int SubscriptionId
        );
}
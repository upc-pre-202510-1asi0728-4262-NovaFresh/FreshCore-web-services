using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.AccountSubscription.Application.Commands
{
    public record CancelSubscriptionCommand
    {
        [Required]
        public int SubscriptionId { get; init; }
    }
}
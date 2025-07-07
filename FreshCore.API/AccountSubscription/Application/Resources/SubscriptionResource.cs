using FreshCore.API.AccountSubscription.Domain.Models.Entities;
using FreshCore.API.AccountSubscription.Domain.Models.ValueObjects;

namespace FreshCore.API.AccountSubscription.Application.Resources
{
	public record SubscriptionResource(
		int Id,
		int AccountId,
		string Tier,
		DateOnly PaymentDate,
		int SubscriptionStatusId,
		DateOnly LastPaidPeriod
	)
	{
		public static SubscriptionResource FromSubscription(Subscription subscription)
		{
			return new SubscriptionResource(subscription.Id,
				subscription.AccountId,
				((SubscriptionTier)subscription.TierId).ToString(),
				subscription.PaymentDate,
				subscription.SubscriptionStatusId,
				subscription.LastPaidPeriod);
		}
	}
}
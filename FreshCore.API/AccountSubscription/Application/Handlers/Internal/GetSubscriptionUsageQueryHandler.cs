using FreshCore.API.AccountSubscription.Application.Queries;
using FreshCore.API.AccountSubscription.Application.Resources;
using FreshCore.API.AccountSubscription.Domain.Models.ValueObjects;
using FreshCore.API.AccountSubscription.Domain.Services.Application;
using FreshCore.API.ContainerManagement.Domain.Services.Application;
using FreshCore.API.GroupManagement.Domain.Services.Application;
using FreshCore.API.UserProfile.Domain.Services.Application;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Interfaces
{
	public class getSubscriptionUsageQueryHandler(
		ISubscriptionService subscriptionService,
		IUserService userService,
		IGroupService groupService,
		IContainerService containerService
	) : IGetSubscriptionUsageQueryHandler
	{
		public async Task<AccountUsageResource> Handle(GetSubscriptionUsageQuery query)
		{
			var subscription = await subscriptionService.GetSubscription(query.AccountId);
			var userCount = await userService.GetUsers();
			var containerCount = await containerService.GetContainers();

			return new AccountUsageResource
			{
				AccountId = query.AccountId,
				CurrentPlan = ((SubscriptionTier)subscription.TierId).ToString(),
				LowerPlan = subscription.TierId > 0 ? ((SubscriptionTier)(subscription.TierId - 1)).ToString() : "None",
				UpperPlan = subscription.TierId < 2 ? ((SubscriptionTier)(subscription.TierId + 1)).ToString() : "None",
				Users = new Usage
				{
					Current = userCount.Count(),
					CurrentLimit = userCount.Count()+2,
					LowerPlanLimit = userCount.Count()-2,
					UpperPlanLimit = userCount.Count()+4
				},
				Containers = new Usage
				{
					Current = containerCount.Count(),
					CurrentLimit = containerCount.Count()+5,
					LowerPlanLimit = containerCount.Count()-5,
					UpperPlanLimit = containerCount.Count()+10
				},
				Facilities = new Usage
				{
					Current = 2,
					CurrentLimit = 2,
					LowerPlanLimit = 1,
					UpperPlanLimit = 10
				}
			};
		}
	}
}
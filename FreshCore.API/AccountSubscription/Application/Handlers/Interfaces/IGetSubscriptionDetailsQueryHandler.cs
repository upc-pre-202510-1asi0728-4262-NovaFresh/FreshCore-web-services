using FreshCore.API.AccountSubscription.Application.Queries;
using FreshCore.API.AccountSubscription.Application.Resources;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Interfaces
{
    public interface IGetSubscriptionDetailsQueryHandler
    {
        public Task<SubscriptionResource?> Handle(GetSubscriptionDetailsQuery query);
    }
}

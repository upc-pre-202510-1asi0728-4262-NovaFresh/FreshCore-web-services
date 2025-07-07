using FreshCore.API.AccountSubscription.Application.Commands;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Interfaces
{
    public interface IUpgradeSubscriptionCommandHandler
    {
        public Task Handle(UpgradeSubscriptionCommand command);
    }
}

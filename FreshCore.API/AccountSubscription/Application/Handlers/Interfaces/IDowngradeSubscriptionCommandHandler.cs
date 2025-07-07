using FreshCore.API.AccountSubscription.Application.Commands;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Interfaces
{
    public interface IDowngradeSubscriptionCommandHandler
    {
        public Task Handle(DowngradeSubscriptionCommand command);
    }
}

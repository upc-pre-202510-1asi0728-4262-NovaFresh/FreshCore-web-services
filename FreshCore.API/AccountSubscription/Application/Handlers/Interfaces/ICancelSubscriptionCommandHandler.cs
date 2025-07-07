using FreshCore.API.AccountSubscription.Application.Commands;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Interfaces
{
    public interface ICancelSubscriptionCommandHandler
    {
        public Task Handle(CancelSubscriptionCommand command);
    }
}

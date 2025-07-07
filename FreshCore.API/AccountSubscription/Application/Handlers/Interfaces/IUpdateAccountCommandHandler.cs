using FreshCore.API.AccountSubscription.Application.Commands;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Interfaces
{
    public interface IUpdateAccountCommandHandler
    {
        public Task Handle(UpdateAccountCommand command);
    }
}

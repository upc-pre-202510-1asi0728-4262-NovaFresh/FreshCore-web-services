using FreshCore.API.AccountSubscription.Application.Commands;
using FreshCore.API.AccountSubscription.Application.Resources;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Interfaces
{
    public interface ICreateAccountCommandHandler
    {
        public Task<AccountResource> Handle(CreateAccountCommand command);
    }
}

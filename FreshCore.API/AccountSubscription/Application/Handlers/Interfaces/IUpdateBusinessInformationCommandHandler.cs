using FreshCore.API.AccountSubscription.Application.Commands;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Interfaces
{
    public interface IUpdateBusinessInformationCommandHandler
    {
        public Task Handle(UpdateBusinessInformationCommand command);
    }
}

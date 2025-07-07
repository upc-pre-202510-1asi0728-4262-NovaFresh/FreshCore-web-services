namespace FreshCore.API.GroupManagement.Domain.Models.Commands
{
    public interface IRegisterUserCommandHandler 
    {
        public Task Handle(RegisterUserCommand command);
    }
}
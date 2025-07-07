using FreshCore.API.GroupManagement.Domain.Models.Resources;

namespace FreshCore.API.GroupManagement.Domain.Models.Commands
{
    public interface ICreateGroupCommandHandler
    {
        public Task<GroupResource> Handle(CreateGroupCommand command);
    }
}
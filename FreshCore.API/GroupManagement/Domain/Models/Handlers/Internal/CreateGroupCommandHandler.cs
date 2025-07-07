using FreshCore.API.GroupManagement.Domain.Models.Commands;
using FreshCore.API.GroupManagement.Domain.Models.Resources;
using FreshCore.API.GroupManagement.Domain.Services.Application;
using FreshCore.API.Shared.Domain.Repositories;
using FreshCore.API.GroupManagement.Domain.Models.Entities;


namespace FreshCore.API.GroupManagement.Domain.Models.Handlers.Internal
{
    public class CreateGroupCommandHandler(
        IGroupService groupService,
        IUnitOfWork unitOfWork
    ) : ICreateGroupCommandHandler
    {

        public async Task<GroupResource> Handle(CreateGroupCommand command)
        {
            var group = await groupService.CreateGroup(command.AccountId, command.Name, command.Location, command.FacilityType);
            await unitOfWork.CompleteAsync();
            return GroupResource.FromGroup(group);
        }
    }
}
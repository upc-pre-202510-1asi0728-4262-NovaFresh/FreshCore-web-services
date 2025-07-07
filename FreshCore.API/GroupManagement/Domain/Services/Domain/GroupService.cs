using FreshCore.API.GroupManagement.Domain.Models.Commands;
using FreshCore.API.GroupManagement.Domain.Models.Entities;
using FreshCore.API.GroupManagement.Domain.Models.Handlers.Internal;
using FreshCore.API.GroupManagement.Domain.Models.ValueObject;
using FreshCore.API.GroupManagement.Domain.Repositories;
using FreshCore.API.GroupManagement.Domain.Services.Application;
using Microsoft.EntityFrameworkCore; 


namespace FreshCore.API.GroupManagement.Domain.Services.Domain
{
    public class GroupService(
        IGroupRepository groupRepository
    ) : IGroupService
    {
        public async Task<Group> CreateGroup(int accountId, string name, Location location, FacilityType facilityType)
        {
            var group = new Group(accountId, name, location, facilityType, 0, 0);
            await groupRepository.Add(group);
            return group;
        }
        public async Task DeleteGroup(int id)
        {
            var group = await groupRepository.GetById(id);
            if (group != null)
            {
                await groupRepository.Delete(group);
            }
        }
        public async Task<Group> GetGroup(int id)
        {
            var groups = await groupRepository.GetAllSync(); 
            var group = await groups
                .Include(g => g.Location)
                .Include(g => g.Containers)
                .Include(g => g.Profiles)
                .FirstOrDefaultAsync(g => g.Id == id);

            if (group == null)
            {
                throw new Exception("Group not found");
            }
            group.ProfileCount = group.Profiles.Count;
            group.ContainerCount = group.Containers.Count;

            return group;
        }

        public IEnumerable<Group> GetGroups(int accountId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Group>> GetGroupsByAccountId(int accountId)
        {
            var groups = await groupRepository.GetAllSync(); // Asegúrate de que esto devuelva Task<IQueryable<Group>>
            var groupList = await groups
                .Where(g => g.AccountId == accountId)
                .Include(g => g.Location)
                .Include(g => g.Containers)
                .Include(g => g.Profiles)
                .ToListAsync();

            // Actualizar el número de perfiles y contenedores asociados a cada grupo
            foreach (var group in groupList)
            {
                group.ProfileCount = group.Profiles.Count;
                group.ContainerCount = group.Containers.Count;
            }

            return groupList;
        }

        public void RegisterContainer(int groupId, int containerId)
        {
            throw new NotImplementedException();
        }

        public Group UpdateGroup(int id, string name, Location location)
        {
            // Implementación del método
            throw new NotImplementedException();
        }

        Task<IEnumerable<Group>> IGroupService.GetGroups(int accountId)
        {
            throw new NotImplementedException();
        }

        Task IGroupService.RegisterContainer(int groupId, int containerId)
        {
            throw new NotImplementedException();
        }

        Task<Group> IGroupService.UpdateGroup(int id, string name, Location location)
        {
            throw new NotImplementedException();
        }
    }
}
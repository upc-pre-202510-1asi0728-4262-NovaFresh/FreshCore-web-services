using System.ComponentModel;
using FreshCore.API.ContainerManagement.Interface.Resources;
using FreshCore.API.GroupManagement.Domain.Models.Queries;

namespace FreshCore.API.GroupManagement.Domain.Models.Handlers.Interfaces
{
    public interface IGetContainersByGroupIdQueryHandler
    {
        public Task<IEnumerable<ContainerResource>> Handle (GetContainersByGroupIdQuery query);
    }
}
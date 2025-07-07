using FreshCore.API.AccountSubscription.Application.Queries;
using FreshCore.API.GroupManagement.Domain.Models.Resources;

namespace FreshCore.API.AccountSubscription.Application.Handlers.Interfaces
{
    public interface IGetGroupsByAccountIdQueryHandler
    {
        Task<IEnumerable<GroupResource>> Handle(GetGroupsByAccountIdQuery query);
    }
}
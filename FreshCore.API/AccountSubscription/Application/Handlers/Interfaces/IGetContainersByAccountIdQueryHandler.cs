using FreshCore.API.ContainerManagement.Interface.Resources;

namespace FreshCore.API.AccountSubscription.Application.Queries
{
    public interface IGetContainersByAccountIdQueryHandler
    {
        Task<IEnumerable<ContainerResource>> Handle(GetContainersByAccountIdQuery query);
    }
}
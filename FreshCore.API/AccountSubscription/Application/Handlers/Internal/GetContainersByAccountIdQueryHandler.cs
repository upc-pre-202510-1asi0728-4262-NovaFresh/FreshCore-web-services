using FreshCore.API.ContainerManagement.Domain.Services.Application;
using FreshCore.API.ContainerManagement.Interface.Resources;

namespace FreshCore.API.AccountSubscription.Application.Queries
{
    public class GetContainersByAccountIdQueryHandler(
        IContainerService containerService
    ) : IGetContainersByAccountIdQueryHandler
    {
        public async Task<IEnumerable<ContainerResource>> Handle(GetContainersByAccountIdQuery query)
        {
            var result = await containerService.GetContainersByAccountId(query.AccountId);
            return result.Select(ContainerResource.FromContainer);

        }
    }
}
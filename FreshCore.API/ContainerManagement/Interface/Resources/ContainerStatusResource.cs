using FreshCore.API.ContainerManagement.Domain.Models.Entities;
using FreshCore.API.ContainerManagement.Domain.Models.ValueObjects;

namespace FreshCore.API.ContainerManagement.Interface.Resources
{
    public record ContainerStatusResource(
        string LastKnownContainerStatus,
        DateTime LastKnownContainerStatusReport
        )
    {
        public static ContainerStatusResource FromContainer(Container container)
        {
            return new ContainerStatusResource(
                ((ContainerStatus)container.LastKnownContainerStatus).ToString(),
                container.LastKnownContainerStatusReport
            );
        }
    }
}
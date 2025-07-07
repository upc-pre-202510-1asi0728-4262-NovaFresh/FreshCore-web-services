using FreshCore.API.ContainerManagement.Domain.Models.Entities;
using FreshCore.API.ContainerManagement.Domain.Models.ValueObjects;

namespace FreshCore.API.ContainerManagement.Interface.Resources
{
    public record ContainerHealthResource (
        string LastKnownContainerHealth,
        DateTime? LastKnownContainerHealthReport)
    {
        public static ContainerHealthResource FromContainer(Container container)
        {
            return new ContainerHealthResource(
                ((ContainerStatus)container.LastKnownHealthStatus).ToString(),
                container.LastKnownHealthStatusReport
            );
        }
    }
}
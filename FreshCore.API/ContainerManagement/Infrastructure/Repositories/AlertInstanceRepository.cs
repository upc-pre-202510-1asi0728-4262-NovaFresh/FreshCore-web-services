using FreshCore.API.ContainerManagement.Domain.Models.ValueObjects;
using FreshCore.API.ContainerManagement.Domain.Repositories;
using FreshCore.API.Shared.Infrastructure;
using FreshCore.API.Shared.Infrastructure.Repositories;

namespace FreshCore.API.ContainerManagement.Infrastructure.Repositories
{
    public class AlertInstanceRepository : BaseRepository<AlertInstance>, IAlertInstanceRepository
    {
        public AlertInstanceRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

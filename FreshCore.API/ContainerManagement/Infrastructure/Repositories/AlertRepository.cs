using FreshCore.API.ContainerManagement.Domain.Models.Entities;
using FreshCore.API.ContainerManagement.Domain.Repositories;
using FreshCore.API.Shared.Infrastructure;
using FreshCore.API.Shared.Infrastructure.Repositories;

namespace FreshCore.API.ContainerManagement.Infrastructure.Repositories
{
    public class AlertRepository : BaseRepository<Alert>, IAlertRepository
    {
        public AlertRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

using FreshCore.API.ContainerManagement.Application.Queries;
using FreshCore.API.ContainerManagement.Interface.Resources;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Interfaces
{
    public interface IGetTemplatesQueryHandler
    {
        public Task<IEnumerable<TemplateResource>> Handle(GetTemplatesQuery query);
    }
}
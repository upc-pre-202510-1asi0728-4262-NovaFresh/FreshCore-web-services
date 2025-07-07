using FreshCore.API.ContainerManagement.Application.Queries;
using FreshCore.API.ContainerManagement.Interface.Resources;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Interfaces
{
    public interface IGetTemplateQueryHandler
    {
        public Task<TemplateResource?> Handle(GetTemplateQuery query);
    }
}
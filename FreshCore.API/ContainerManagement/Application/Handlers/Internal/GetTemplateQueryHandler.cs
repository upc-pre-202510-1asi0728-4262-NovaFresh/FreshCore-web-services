using FreshCore.API.ContainerManagement.Application.Handlers.Interfaces;
using FreshCore.API.ContainerManagement.Application.Queries;
using FreshCore.API.ContainerManagement.Domain.Services.Application;
using FreshCore.API.ContainerManagement.Interface.Resources;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Internal
{
    public class GetTemplateQueryHandler(
		ITemplateService templateService
	) : IGetTemplateQueryHandler
    {
        public async Task<TemplateResource?> Handle(GetTemplateQuery query)
        {
			var template = await templateService.GetTemplate(query.TemplateId);
			return TemplateResource.FromTemplate(template);
        }
    }
}
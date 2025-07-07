using FreshCore.API.ContainerManagement.Application.Handlers.Interfaces;
using FreshCore.API.ContainerManagement.Application.Queries;
using FreshCore.API.ContainerManagement.Domain.Services.Application;
using FreshCore.API.ContainerManagement.Interface.Resources;

namespace FreshCore.API.ContainerManagement.Application.Handlers.Internal
{
	public class GetTemplatesQueryHandler(ITemplateService templateService) : IGetTemplatesQueryHandler
	{

		public async Task<IEnumerable<TemplateResource>> Handle(GetTemplatesQuery query)
		{
			var templates = await templateService.GetTemplates();
			return templates.Select(TemplateResource.FromTemplate);
		}
	}
}
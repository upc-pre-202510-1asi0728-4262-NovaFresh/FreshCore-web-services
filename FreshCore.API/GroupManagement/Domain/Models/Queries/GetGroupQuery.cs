using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.GroupManagement.Domain.Models.Queries
{
    public record GetGroupQuery(
        [Required] int GroupId
    );
}
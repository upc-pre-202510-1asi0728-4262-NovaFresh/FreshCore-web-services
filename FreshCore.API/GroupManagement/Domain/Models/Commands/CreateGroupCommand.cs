using System.ComponentModel.DataAnnotations;
using FreshCore.API.GroupManagement.Domain.Models.Entities;
using FreshCore.API.GroupManagement.Domain.Models.ValueObject;

namespace FreshCore.API.GroupManagement.Domain.Models.Commands
{
    public record CreateGroupCommand(
        [Required, StringLength(64)] string Name,
        [Required] Location Location,
        [Required] int AccountId,
        [Required] FacilityType FacilityType
    );
}
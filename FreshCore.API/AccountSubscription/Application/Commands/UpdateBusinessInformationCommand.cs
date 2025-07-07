using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.AccountSubscription.Application.Commands
{
    public record UpdateBusinessInformationCommand
    (
        [Required] int AccountId,
        [Required] string BusinessName,
        [Required] string BusinessId
        );
}
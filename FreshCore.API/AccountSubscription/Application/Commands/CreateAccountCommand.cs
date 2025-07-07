using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.AccountSubscription.Application.Commands
{
    public record CreateAccountCommand
    (
        [Required] string BusinessName,
        [Required] string BusinessId,
        [Required] int RepresentativeId
    );
}
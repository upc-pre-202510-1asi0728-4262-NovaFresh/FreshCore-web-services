using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.AccountSubscription.Application.Commands
{
    public record UpdateAccountCommand
    (
        [Required] int AccountId,
		[Required] int RepresentativeId
        );
}
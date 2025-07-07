using System.ComponentModel.DataAnnotations;

namespace FreshCore.API.AccountSubscription.Application.Commands
{
    public record DeleteAccountCommand
    (
        [Required] int AccountId
    );
}

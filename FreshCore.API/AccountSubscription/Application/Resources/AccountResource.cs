using System.ComponentModel.DataAnnotations;
using FreshCore.API.AccountSubscription.Domain.Models.Aggregates;

namespace FreshCore.API.AccountSubscription.Application.Resources
{
	public record AccountResource
	(
		[Required] int Id,
		[Required] string BusinessName,
		[Required] string BussinessId,
		[Required] int RepresentativeId)
	{
		public static AccountResource FromAccount(Account account)
		{
			return new AccountResource(
				account.Id,
				account.BusinessName,
				account.BusinessId,
				account.RepresentativeId
			);
		}


	}
}
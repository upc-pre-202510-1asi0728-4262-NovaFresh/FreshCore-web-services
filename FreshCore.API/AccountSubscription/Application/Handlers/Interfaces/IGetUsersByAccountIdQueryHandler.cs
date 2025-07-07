using FreshCore.API.UserProfile.Application.Resources;
using FreshCore.API.UserProfile.Domain.Models.Entities;

namespace FreshCore.API.AccountSubscription.Application.Queries
{
    public interface IGetUsersByAccountIdQueryHandler
    {
        Task<IEnumerable<ProfileResource>> Handle(GetUsersByAccountIdQuery query);
    }
}
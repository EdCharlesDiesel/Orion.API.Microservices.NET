using Orion.API.TradingEconomics.API.Services;

namespace Orion.API.UserProfile.API.Services;

public interface IUserProfileServices:IRepository<OrionUserProfile.Domain.UserProfile>
{
    
    Task<string> GetUserProfilesByDate(DateTime startDate, DateTime endDate);
    Task<string> GetUserProfilesByCountries(params string[] countries);
    Task<string> GetUserProfilesByCountriesAndDates(DateTime startDate, DateTime endDate, params string[] countries);
    Task<string> GetUserProfilesByIndicator(params string[] indicators);
    Task<OrionUserProfile.Domain.UserProfile> Create(OrionUserProfile.Domain.UserProfile userProfile);
}
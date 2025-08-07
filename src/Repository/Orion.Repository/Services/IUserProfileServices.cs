namespace Orion.Repository.Services;
public interface IUserProfileServices:IRepository<Core.UserProfile.Domain.UserProfile>
{
    Task<string> GetUserProfilesByDate(DateTime startDate, DateTime endDate);
    Task<string> GetUserProfilesByCountries(params string[] countries);
    Task<string> GetUserProfilesByCountriesAndDates(DateTime startDate, DateTime endDate, params string[] countries);
    Task<string> GetUserProfilesByIndicator(params string[] indicators);
    Task<Core.UserProfile.Domain.UserProfile> Create(Core.UserProfile.Domain.UserProfile userProfile);
}
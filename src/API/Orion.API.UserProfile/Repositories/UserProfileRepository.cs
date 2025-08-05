using Orion.API.UserProfile.API.Data;
using Orion.API.UserProfile.API.Services;

namespace Orion.API.UserProfile.API.Repositories;

public class UserProfileRepository: IUserProfileServices
{
    private readonly UserProfileContext _context;

    public UserProfileRepository(UserProfileContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<OrionUserProfile.Domain.UserProfile>> GetAllAsync()
    {
        var userProfiles = _context.UserProfiles.ToList();
        if (userProfiles == null || !userProfiles.Any())
            throw new ArgumentException("Event list cannot be null or empty.");

        // Return the first created event (or you can change this to return the list)
        return userProfiles.ToList();
    }

    public async Task<string> GetUserProfilesByDate(DateTime startDate, DateTime endDate)
    {
        if (startDate == default || endDate == default)
            return "Invalid date range";

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        return await HttpRequesterClass.HttpRequester($"/calendar/country/all/{textStartDate}/{textEndDate}");
    }

    public async Task<string> GetUserProfilesByCountries(params string[] countries)
    {
        if (countries.Any(string.IsNullOrWhiteSpace))
            return "Invalid country names";

        return await HttpRequesterClass.HttpRequester($"/calendar/country/{string.Join(",", countries)}");
    }

    public async Task<string> GetUserProfilesByCountriesAndDates(DateTime startDate, DateTime endDate, params string[] countries)
    {
        if (startDate == default || endDate == default || countries.Any(string.IsNullOrWhiteSpace))
            return "Invalid input";

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        return await HttpRequesterClass.HttpRequester($"/calendar/country/{string.Join(",", countries)}/{textStartDate}/{textEndDate}");
    }

    public async Task<string> GetUserProfilesByIndicator(params string[] indicators)
    {
        if (indicators.Any(string.IsNullOrWhiteSpace))
            return "Invalid indicator names";

        return await HttpRequesterClass.HttpRequester($"/calendar/indicator/{string.Join(",", indicators)}");
    }

    public async Task<OrionUserProfile.Domain.UserProfile> Create(OrionUserProfile.Domain.UserProfile userProfiles)
    {
        if (userProfiles == null)
            throw new ArgumentException("Event list cannot be null or empty.");

        await _context.UserProfiles.AddAsync(userProfiles);
        await _context.SaveChangesAsync();

        // Return the first created event (or you can change this to return the list)
        return userProfiles;
    }


    public async Task<OrionUserProfile.Domain.UserProfile> Create(List<OrionUserProfile.Domain.UserProfile> userProfiles)
    {
        if (userProfiles == null || !userProfiles.Any())
            throw new ArgumentException("Event list cannot be null or empty.");

        await _context.UserProfiles.AddRangeAsync(userProfiles);
        await _context.SaveChangesAsync();

        // Return the first created event (or you can change this to return the list)
        return userProfiles.First();
    }



    public async Task<OrionUserProfile.Domain.UserProfile?> GetByIdAsync(object id)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(OrionUserProfile.Domain.UserProfile entity)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(OrionUserProfile.Domain.UserProfile entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(object id)
    {
        throw new NotImplementedException();
    }
}
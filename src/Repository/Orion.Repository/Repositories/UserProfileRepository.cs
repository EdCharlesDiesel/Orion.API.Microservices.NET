using Orion.Core.UserProfile.Domain;
using Orion.Helpers;
using Orion.Repository.Data;
using Orion.Repository.Services;

namespace Orion.Repository.Repositories;

public class UserProfileRepository(OrionDbContext dbContext) : IUserProfileServices
{
    public async Task<IEnumerable<UserProfile>> GetAllAsync()
    {
        // var userProfiles = _dbContext.UserProfiles.ToList();
        // if (userProfiles == null || !userProfiles.Any())
        //     throw new ArgumentException("Event list cannot be null or empty.");
        //
        // // Return the first created event (or you can change this to return the list)
        // return userProfiles.ToList<Core.UserProfile.Domain.UserProfile>();

        throw new NotImplementedException();
    }

    public async Task<Core.UserProfile.Domain.UserProfile?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
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

    public async Task<string> GetUserProfilesByCountriesAndDates(DateTime startDate, DateTime endDate,
        params string[] countries)
    {
        if (startDate == default || endDate == default || countries.Any(string.IsNullOrWhiteSpace))
            return "Invalid input";

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        return await HttpRequesterClass.HttpRequester(
            $"/calendar/country/{string.Join(",", countries)}/{textStartDate}/{textEndDate}");
    }

    public async Task<string> GetUserProfilesByIndicator(params string[] indicators)
    {
        if (indicators.Any(string.IsNullOrWhiteSpace))
            return "Invalid indicator names";

        return await HttpRequesterClass.HttpRequester($"/calendar/indicator/{string.Join(",", indicators)}");
    }

    public async Task<Core.UserProfile.Domain.UserProfile> Create(Core.UserProfile.Domain.UserProfile userProfiles)
    {
        if (userProfiles == null)
            throw new ArgumentException("Event list cannot be null or empty.");

        // await _dbContext.UserProfiles.AddAsync(userProfiles);
        // await _dbContext.SaveChangesAsync();

        // Return the first created event (or you can change this to return the list)
        return userProfiles;
    }


    public async Task<Core.UserProfile.Domain.UserProfile> Create(
        List<Core.UserProfile.Domain.UserProfile> userProfiles)
    {
        if (userProfiles == null || !userProfiles.Any())
            throw new ArgumentException("Event list cannot be null or empty.");

        // await _dbContext.UserProfiles.AddRangeAsync((List<Core.UserProfile.Domain.UserProfile>)userProfiles);
        await dbContext.SaveChangesAsync();

        // Return the first created event (or you can change this to return the list)
        return userProfiles.First();
    }



    public async Task<Core.UserProfile.Domain.UserProfile?> GetByIdAsync(object id)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Core.UserProfile.Domain.UserProfile entity)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(Core.UserProfile.Domain.UserProfile entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
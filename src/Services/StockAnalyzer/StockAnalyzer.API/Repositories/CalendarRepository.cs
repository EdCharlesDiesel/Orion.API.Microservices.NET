namespace Orion.Services.StockAnalyzer.API.Repositories;

public class CalendarRepository: ICalendarServices
{
    public async Task<string> GetCalendarEvents()
    {
        return await Helper.HttpRequesterClass.HttpRequester("/calendar");
    }

    public async Task<string> GetCalendarEventsByDate(DateTime startDate, DateTime endDate)
    {
        if (startDate == default || endDate == default)
            return "Invalid date range";

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        return await Helper.HttpRequesterClass.HttpRequester($"/calendar/country/all/{textStartDate}/{textEndDate}");
    }

    public async Task<string> GetCalendarEventsByCountries(params string[] countries)
    {
        if (countries.Any(string.IsNullOrWhiteSpace))
            return "Invalid country names";

        return await Helper.HttpRequesterClass.HttpRequester($"/calendar/country/{string.Join(",", countries)}");
    }

    public async Task<string> GetCalendarEventsByCountriesAndDates(DateTime startDate, DateTime endDate, params string[] countries)
    {
        if (startDate == default || endDate == default || countries.Any(string.IsNullOrWhiteSpace))
            return "Invalid input";

        string textStartDate = startDate.ToString("yyyy-MM-dd");
        string textEndDate = endDate.ToString("yyyy-MM-dd");

        return await Helper.HttpRequesterClass.HttpRequester($"/calendar/country/{string.Join(",", countries)}/{textStartDate}/{textEndDate}");
    }

    public async Task<string> GetCalendarEventsByIndicator(params string[] indicators)
    {
        if (indicators.Any(string.IsNullOrWhiteSpace))
            return "Invalid indicator names";

        return await Helper.HttpRequesterClass.HttpRequester($"/calendar/indicator/{string.Join(",", indicators)}");
    }


}
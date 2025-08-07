using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using System.Text;

namespace Orion.Repository.Repositories.TradingEconomics;
public class TradingEconomicsService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "guest:guest";

    public TradingEconomicsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://api.tradingeconomics.com");
        var encodedKey = Convert.ToBase64String(Encoding.UTF8.GetBytes(_apiKey));
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encodedKey);
    }

    public async Task<string> GetLatestNewsAsync()
    {
        var response = await _httpClient.GetAsync("/news");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> GetNewsByCountryAsync(string[] countries)
    {
        string path = $"/news/country/{string.Join(",", countries)}";
        var response = await _httpClient.GetAsync(path);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> GetNewsByIndicatorAsync(string[] indicators)
    {
        string path = $"/news/indicator/{string.Join(",", indicators)}";
        var response = await _httpClient.GetAsync(path);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
    
    public async Task<string> GetIntradaySymbolAsync(string symbol)
    {
        var response = await _httpClient.GetAsync($"/markets/intraday/{symbol}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> GetIntradayDateHourAsync(string symbol, DateTime startDate)
    {
        var query = startDate.ToString("yyyy-MM-dd HH");
        var response = await _httpClient.GetAsync($"/markets/intraday/{symbol}?{query}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> GetIntradaySymbolDatesAsync(string symbol, DateTime startDate, DateTime endDate)
    {
        var start = startDate.ToString("yyyy-MM-dd");
        var end = endDate.ToString("yyyy-MM-dd");
        var response = await _httpClient.GetAsync($"/markets/intraday/{symbol}?{start}/{end}");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}
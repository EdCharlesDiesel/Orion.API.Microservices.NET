namespace Orion.Services.Basket.API.Services;

public interface IBasketServices:IRepository<Core.Basket.Domain.Basket>
{
    
    Task<string> GetBasketsByDate(DateTime startDate, DateTime endDate);
    Task<string> GetBasketsByCountries(params string[] countries);
    Task<string> GetBasketsByCountriesAndDates(DateTime startDate, DateTime endDate, params string[] countries);
    Task<string> GetBasketsByIndicator(params string[] indicators);
    Task<Core.Basket.Domain.Basket> Create(Core.Basket.Domain.Basket userProfile);
}
using Microsoft.AspNetCore.Mvc;

namespace Orion.Services.StockAnalyzer.API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class Comtrade :  ControllerBase
{
        /// <summary>
        /// get categories
        /// </summary>
        /// <returns>A task that will be resolved in a string with the request result</returns>
        public static async Task<string> GetComCategories()
        {
            return await Orion.Services.StockAnalyzer.API.Helper.HttpRequesterClass.HttpRequester("/comtrade/categories");
        }

        /// <summary>
        /// get countries
        /// </summary>
        /// <returns>A task that will be resolved in a string with the request result</returns>
        public static async Task<string> GetComCountries()
        {
            return await Orion.Services.StockAnalyzer.API.Helper.HttpRequesterClass.HttpRequester("/comtrade/countries");
        }

    
        /// <summary>
        /// Get comtrade by country and page number
        /// </summary>
        /// <param name="country">country</param>
        /// <param name="page_number">pagination</param>
        /// <returns>A task that will be resolved in a string with the request result</returns>
        public static async Task<string> GetComCountryPage(string country, int page_number)
        {

            return await Orion.Services.StockAnalyzer.API.Helper.HttpRequesterClass.HttpRequester($"/comtrade/country/{country}/{page_number}");
        }


        /// <summary>
        /// Get comtrade between 2 countries and page number
        /// </summary>
        /// <param name="country1">country</param>
        /// <param name="country2">country</param>
        /// <param name="page_number">pagination</param>
        /// <returns>A task that will be resolved in a string with the request result</returns>
        public static async Task<string> GetComBetweenCountries(string country1, string country2, int page_number)
        {

            return await Orion.Services.StockAnalyzer.API.Helper.HttpRequesterClass.HttpRequester($"/comtrade/country/{country1}/{country2}/{page_number}");
        }

        /// <summary>
        /// Get historical by symbol
        /// </summary>
        /// <param name="symbol">country</param>
        /// <returns>A task that will be resolved in a string with the request result</returns>
        public static async Task<string> GetComHistorical(string symbol)
        {

            return await Orion.Services.StockAnalyzer.API.Helper.HttpRequesterClass.HttpRequester($"/comtrade/historical/{symbol}");
        }

       
}
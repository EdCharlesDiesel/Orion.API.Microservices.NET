using System;
using System.Net.Http;
using System.Threading.Tasks;
using Orion.Shopping.Aggregator.Models;
using Shopping.Aggregator.Extensions;

namespace Orion.Shopping.Aggregator.Services
{
    public class BasketService(HttpClient client) : IBasketService
    {
        private readonly HttpClient _client = client ?? throw new ArgumentNullException(nameof(client));

        public async Task<BasketModel> GetBasket(string userName)
        {
            var response = await _client.GetAsync($"/api/v1/Basket/{userName}");
            return await response.ReadContentAs<BasketModel>();
        }        
    }
}

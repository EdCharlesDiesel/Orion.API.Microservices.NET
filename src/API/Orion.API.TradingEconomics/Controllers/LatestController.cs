using System.Net;
using Microsoft.AspNetCore.Mvc;
using Orion.Services.TradingEcomomics.API.ActionFilters;
using Orion.Services.TradingEconomics.API.Helper;

namespace Orion.API.TradingEconomics.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LatestController : ControllerBase
    {

        /// <summary>
        /// Get the latest news from trading economics
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        
        //[CheckClientKeyHeader]
        public async Task<IActionResult> getLatestUpdates()
        {              
            var getLatestUpdates = GetLatestUpdates().Result;
            return Ok(getLatestUpdates);
        }

        /// <summary>
        /// Get latest updates since a specific date
        /// </summary>        
        /// <returns></returns>
        [HttpGet("{date}", Name = "GetLatestUpdatesByDate")]
        [CheckClientKeyHeader]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]        
        public Task<IActionResult> getLatestUpdatesByDate(DateTime date)
        {            
            var getLatestUpdatesByDate = GetLatestUpdatesByDate(date).Result;

            return Task.FromResult<IActionResult>(Ok(getLatestUpdatesByDate));
        }   

        /// <summary>
        /// Get latest updates with no filters
        /// </summary>
        /// <returns>A task that will be resolved in a string with the request result</returns>
        private static async Task<string> GetLatestUpdates()
        {
            return await HttpRequesterClass.HttpRequester("/updates");
        }

        /// <summary>
        /// Get latest updates by date
        /// </summary>
        /// <param name="startDate">Start date if needed</param>
        /// <returns>A task that will be resolved in a string with the request result</returns>
        private static async Task<string> GetLatestUpdatesByDate(DateTime startDate)
        {
            return await HttpRequesterClass.HttpRequester($"/updates/{startDate.ToString("yyyy-MM-dd")}");
        }
    }
}
    

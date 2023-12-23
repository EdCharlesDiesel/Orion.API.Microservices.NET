using Microsoft.AspNetCore.Mvc;
using Orion.Services.StockAnalyzer.API.ActionFilters;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace StockAnalyzer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LatestController : ControllerBase
    {

        /// <summary>
        /// Get the latest news from trading ecomomics
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
        public async Task<IActionResult> getLatestUpdatesByDate(DateTime date)
        {            
            var getLatestUpdatesByDate = GetLatestUpdatesByDate(date).Result;         

            if (getLatestUpdatesByDate == null)
            {                
                return NotFound();
            }
            return Ok(getLatestUpdatesByDate);
        }   

        /// <summary>
        /// Get latest updates with no filters
        /// </summary>
        /// <returns>A task that will be resolved in a string with the request result</returns>
        public async static Task<string> GetLatestUpdates()
        {
            return await Orion.Services.StockAnalyzer.API.Helper.HttpRequesterClass.HttpRequester("/updates");
        }

        /// <summary>
        /// Get latest updates by date
        /// </summary>
        /// <param name="startDate">Start date if needed</param>
        /// <returns>A task that will be resolved in a string with the request result</returns>
        public async static Task<string> GetLatestUpdatesByDate(DateTime startDate)
        {
            return await Orion.Services.StockAnalyzer.API.Helper.HttpRequesterClass.HttpRequester($"/updates/{startDate.ToString("yyyy-MM-dd")}");
        }
    }
}
    

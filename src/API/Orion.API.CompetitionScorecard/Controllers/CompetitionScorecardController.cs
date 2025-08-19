using Microsoft.AspNetCore.Mvc;
using Orion.Domain.IRepositories;

namespace Orion.API.CompetitionScorecard.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompetitionScorecardController : ControllerBase
    {        

        private readonly ILogger<CompetitionScorecardController> _logger;
        private readonly ICompetitionScorecardServices _service;

        public CompetitionScorecardController(ILogger<CompetitionScorecardController> logger,ICompetitionScorecardServices service)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Get all comtrade categories
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllEvents()
        {
            var result =  _service.GetAllAsync().Result;
            

            return Ok(result);
        }
        
    }
}

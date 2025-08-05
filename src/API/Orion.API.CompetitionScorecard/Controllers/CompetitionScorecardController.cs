using Microsoft.AspNetCore.Mvc;

namespace Orion.API.CompetitionScorecard.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompetitionScorecardController : ControllerBase
    {        

        private readonly ILogger<CompetitionScorecardController> _logger;

        public CompetitionScorecardController(ILogger<CompetitionScorecardController> logger)
        {
            _logger = logger;
        }

        
    }
}

using Microsoft.AspNetCore.Mvc;
using Orion.Services.CompetitionScorecard.API.Entities;

namespace Orion.Services.CompetitionScorecard.API.Controllers
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

        [HttpGet(Name = "CompetitionMatch")]
        public IEnumerable<CompetitionMatch> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new CompetitionMatch
            {
                //Date = DateTime.Now.AddDays(index),
                //TemperatureC = Random.Shared.Next(-20, 55),
                //Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

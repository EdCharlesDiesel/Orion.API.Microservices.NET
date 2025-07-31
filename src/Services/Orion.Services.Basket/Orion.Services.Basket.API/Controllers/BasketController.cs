using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Orion.Services.TradingEconomics.API.DTO;
using Orion.Services.Basket.API.Services;

namespace Orion.Services.Basket.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BasketController : ControllerBase
    {
        private readonly IBasketServices _service;
        private readonly IMapper _mapper;

        public BasketController(IBasketServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        /// <summary>
        /// Get all comtrade categories
        /// </summary>
        [HttpGet]
        public async Task<OkObjectResult> GetAllEvents()
        {
            var result = await _service.GetAllAsync();

            return Ok(result);
        }

        // GET: api/calendar/indicators?names=GDP,Inflation
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromQuery] BasketDto profile)
        {
            var profileToDatabase = _mapper.Map<Core.Basket.Domain.Basket>(profile);
            var result = await _service.Create(profileToDatabase);
            return Ok(result);
        }
        
        // GET: api/calendar/daterange?startDate=2025-07-01&endDate=2025-07-31
        [HttpGet("daterange")]
        public async Task<IActionResult> GetEventsByDate([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var result = await _service.GetBasketsByDate(startDate, endDate);
            return Ok(result);
        }

        // GET: api/calendar/countries?names=South Africa,USA
        [HttpGet("countries")]
        public async Task<IActionResult> GetEventsByCountries([FromQuery] string[] names)
        {
            var result = await _service.GetBasketsByCountries(names);
            return Ok(result);
        }

        // GET: api/calendar/countriesdaterange?startDate=2025-07-01&endDate=2025-07-31&names=USA,Germany
        [HttpGet("countriesdaterange")]
        public async Task<IActionResult> GetEventsByCountriesAndDates([FromQuery] DateTime startDate, [FromQuery] DateTime endDate, [FromQuery] string[] names)
        {
            var result = await _service.GetBasketsByCountriesAndDates(startDate, endDate, names);
            return Ok(result);
        }

        // GET: api/calendar/indicators?names=GDP,Inflation
        [HttpGet("indicators")]
        public async Task<IActionResult> GetEventsByIndicators([FromQuery] string[] names)
        {
            var result = await _service.GetBasketsByIndicator(names);
            return Ok(result);
        }

    }


}
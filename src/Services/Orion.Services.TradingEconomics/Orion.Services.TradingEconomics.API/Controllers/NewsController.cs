using Microsoft.AspNetCore.Mvc;
using Orion.Services.TradingEconomics.API.Services;

namespace Orion.Services.TradingEconomics.API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class NewsController : ControllerBase
{
    private readonly TradingEconomicsService _service;

    public NewsController(TradingEconomicsService service)
    {
        _service = service;
    }

    [HttpGet("latest")]
    public async Task<IActionResult> GetLatestNews()
    {
        var result = await _service.GetLatestNewsAsync();
        return Ok(result);
    }

    [HttpGet("by-country")]
    public async Task<IActionResult> GetNewsByCountry([FromQuery] string[] countries)
    {
        var result = await _service.GetNewsByCountryAsync(countries);
        return Ok(result);
    }

    [HttpGet("by-indicator")]
    public async Task<IActionResult> GetNewsByIndicator([FromQuery] string[] indicators)
    {
        var result = await _service.GetNewsByIndicatorAsync(indicators);
        return Ok(result);
    }
        
}
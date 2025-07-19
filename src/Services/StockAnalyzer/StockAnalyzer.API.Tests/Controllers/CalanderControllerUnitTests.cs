using Microsoft.AspNetCore.Mvc;
using Moq;
using Orion.Services.StockAnalyzer.API.Controllers;
using Orion.Services.StockAnalyzer.API.Repositories;
using Orion.Services.StockAnalyzer.API.Services;
using Orion.StockAnalyzer.Core.Domain;
using Xunit;

namespace Orion.Services.StockAnalyzer.API.Tests.Controllers;

public class CalendarControllerTests
{
    private readonly Mock<CalendarRepository> _mockService;
    private readonly CalendarController _controller;

    public CalendarControllerTests()
    {
        _mockService = new Mock<CalendarRepository>();
        _controller = new CalendarController(_mockService.Object);
    }

    [Fact]
    public async Task GetAllEvents_ReturnsOk()
    {
        // Arrange
        var expected = "All calendar events";
        _mockService.Setup(s => s.GetCalendarEvents()).ReturnsAsync(expected);

        // Act
        var result = await _controller.GetAllEvents();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(expected, okResult.Value);
    }

    [Fact]
    public async Task GetEventsByDate_ReturnsOk()
    {
        var expected = "Events by date";
        var start = new DateTime(2025, 7, 1);
        var end = new DateTime(2025, 7, 31);
        _mockService.Setup(s => s.GetCalendarEventsByDate(start, end)).ReturnsAsync(expected);

        var result = await _controller.GetEventsByDate(start, end);

        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(expected, okResult.Value);
    }

    [Fact]
    public async Task GetEventsByCountries_ReturnsOk()
    {
        var expected = "Events by countries";
        string[] countries = { "South Africa", "USA" };
        _mockService.Setup(s => s.GetCalendarEventsByCountries(countries)).ReturnsAsync(expected);

        var result = await _controller.GetEventsByCountries(countries);

        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(expected, okResult.Value);
    }

    [Fact]
    public async Task GetEventsByCountriesAndDates_ReturnsOk()
    {
        var expected = "Events by countries and date";
        string[] countries = { "USA", "Germany" };
        var start = new DateTime(2025, 7, 1);
        var end = new DateTime(2025, 7, 31);
        _mockService.Setup(s => s.GetCalendarEventsByCountriesAndDates(start, end, countries))
                    .ReturnsAsync(expected);

        var result = await _controller.GetEventsByCountriesAndDates(start, end, countries);

        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(expected, okResult.Value);
    }

    [Fact]
    public async Task GetEventsByIndicators_ReturnsOk()
    {
        var expected = "Events by indicators";
        string[] indicators = { "GDP", "Inflation" };
        _mockService.Setup(s => s.GetCalendarEventsByIndicator(indicators)).ReturnsAsync(expected);

        var result = await _controller.GetEventsByIndicators(indicators);

        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(expected, okResult.Value);
    }
}
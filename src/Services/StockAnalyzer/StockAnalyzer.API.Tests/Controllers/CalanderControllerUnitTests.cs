using Microsoft.AspNetCore.Mvc;
using Orion.Services.StockAnalyzer.API.Controllers;
using Orion.StockAnalyzer.Core.Domain;
using Xunit;

namespace Orion.Services.StockAnalyzer.API.Tests.Controllers;

public class CalanderControllerUnitTests : Controller
{
    public class CalendarControllerTests
    {
        private readonly CalendarController _controller;

        public CalendarControllerTests()
        {
            _controller = new CalendarController();
        }

        [Fact]
        public void GetAll_ReturnsAllEvents()
        {
            // Act
            var result = _controller.GetAll();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var events = Assert.IsAssignableFrom<IEnumerable<Calendar>>(okResult.Value);
            Assert.True(events.Any());
        }

        [Fact]
        public void GetById_ReturnsCorrectEvent()
        {
            // Arrange
            var allEvents = (_controller.GetAll().Result as OkObjectResult)?.Value as List<Calendar>;
            var target = allEvents.First();

            // Act
            var result = _controller.GetById(target.Id);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var calendar = Assert.IsType<Calendar>(okResult.Value);
            Assert.Equal(target.Id, calendar.Id);
        }

        [Fact]
        public void GetById_ReturnsNotFound_WhenInvalid()
        {
            var result = _controller.GetById(Guid.NewGuid());

            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public void Create_AddsNewEvent()
        {
            // Arrange
            var newEvent = new Calendar { EventName = "Test Event", Date = DateTime.Now.AddDays(5) };

            // Act
            var result = _controller.Create(newEvent);

            // Assert
            var createdAt = Assert.IsType<CreatedAtActionResult>(result.Result);
            var calendar = Assert.IsType<Calendar>(createdAt.Value);
            Assert.Equal("Test Event", calendar.EventName);
        }

        [Fact]
        public void Update_ModifiesExistingEvent()
        {
            // Arrange
            var allEvents = (_controller.GetAll().Result as OkObjectResult)?.Value as List<Calendar>;
            var target = allEvents.First();
            var updated = new Calendar { EventName = "Updated Event", Date = DateTime.Now.AddDays(10) };

            // Act
            var result = _controller.Update(target.Id, updated);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public void Delete_RemovesEvent()
        {
            // Arrange
            var allEvents = (_controller.GetAll().Result as OkObjectResult)?.Value as List<Calendar>;
            var target = allEvents.First();

            // Act
            var result = _controller.Delete(target.Id);

            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public void Delete_ReturnsNotFound_IfMissing()
        {
            var result = _controller.Delete(Guid.NewGuid());
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using StockAnalyzer.API.Controllers;
using Xunit;

namespace StockAnalyzer.API.Tests
{
    public class LatestControllerTest
    {
        private readonly LatestController _controller;
        
        public LatestControllerTest()
        {            
            _controller = new LatestController();
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.getLatestUpdates().Result;
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact(Skip ="I'll sort this one later")]
        public void Get_WhenCalled_ReturnsAllItems()
        {
           // Act
           //var okResult = _controller.getLatestUpdates().Result;
           // Assert
           //var items = Assert.IsType<JsonResult>(okResult);
            //Assert.Equal(OkObjectResult, items.StatusCode);
        }

        [Fact]
        public void getLatestUpdatesByDate_WhenCalled_ReturnsOkResult()
        {
            // Act
            var date = new DateTime(2019, 05, 09, 9, 15, 0);
            var okResult = _controller.getLatestUpdatesByDate(date).Result;
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact(Skip = "I'll sort this one later")]
        public void getLatestUpdatesByDate_WhenCalled_ReturnsAllItems()
        {
            // Act
            //var okResult = _controller.getLatestUpdates().Result;
            // Assert
            //var items = Assert.IsType<JsonResult>(okResult);
            //Assert.Equal(OkObjectResult, items.StatusCode);
        }
    }
}
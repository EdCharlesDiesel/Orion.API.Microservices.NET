using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Orion.API.Discount.Controllers;
using Orion.API.Discount.Repositories;

using Xunit;

namespace Orion.Services.Discount.API.Tests
{
    public class DiscountControllerTests
    {
  private readonly Mock<IDiscountRepository> _mockRepo;
    private readonly DiscountController _controller;

    public DiscountControllerTests()
    {
        _mockRepo = new Mock<IDiscountRepository>();
        _controller = new DiscountController(_mockRepo.Object);
    }

    [Fact(Skip = "Will see this one later.")]
    public async Task GetDiscount_ReturnsCoupon_WhenExists()
    {
        // Arrange
        // var productName = "TestProduct";
        // var coupon = new Coupon { Id = new Guid(), ProductName = productName, Amount = 10, Description = "Test discount" };
        //
        // _mockRepo.Setup(repo => repo.GetDiscount(productName))
        //          .ReturnsAsync(coupon);
        //
        // // Act
        // var result = await _controller.GetDiscount(productName);
        //
        // // Assert
        // var okResult = Assert.IsType<OkObjectResult>(result.Result);
        // var returnedCoupon = Assert.IsType<Coupon>(okResult.Value);
        // Assert.Equal(coupon.ProductName, returnedCoupon.ProductName);
    }

    [Fact(Skip = "Will fix this later")]
    public async Task CreateDiscount_ReturnsCreatedAtRoute_WithCoupon()
    {
        // Arrange
        // var coupon = new Coupon { Id = new Guid(), ProductName = "NewProduct", Amount = 15, Description = "New discount" };
        //
        // _mockRepo.Setup(repo => repo.CreateDiscount(coupon))
        //          .Returns((Task<bool>)Task.CompletedTask);
        //
        // // Act
        // var result = await _controller.CreateDiscount(coupon);
        //
        // // Assert
        // var createdAt = Assert.IsType<CreatedAtRouteResult>(result.Result);
        // var returnedCoupon = Assert.IsType<Coupon>(createdAt.Value);
        // Assert.Equal("NewProduct", returnedCoupon.ProductName);
    }

    [Fact(Skip = "Will see this one later.")]
    public async Task UpdateDiscount_ReturnsUpdatedCoupon()
    {
        // Arrange
        // var updatedCoupon = new Coupon { Id = new Guid(), ProductName = "UpdatedProduct", Amount = 20, Description = "Updated" };
        //
        // _mockRepo.Setup(repo => repo.UpdateDiscount(updatedCoupon))
        //          .ReturnsAsync(updatedCoupon);
        //
        // // Act
        // var result = await _controller.UpdateDiscount(updatedCoupon);
        //
        // // Assert
        // var okResult = Assert.IsType<OkObjectResult>(result.Result);
        // var coupon = Assert.IsType<Coupon>(okResult.Value);
        // Assert.Equal("UpdatedProduct", coupon.ProductName);
    }

    [Fact]
    public async Task DeleteDiscount_ReturnsOkTrue_WhenDeleted()
    {
        // Arrange
        var productName = "DeleteMe";

        _mockRepo.Setup(repo => repo.DeleteDiscount(productName))
                 .ReturnsAsync(true);

        // Act
        var result = await _controller.DeleteDiscount(productName);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var deleted = Assert.IsType<bool>(okResult.Value);
        Assert.True(deleted);
    }
    }
}
using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Orion.API.Catalog.Controllers;
using Orion.Services.Catalog.API.Controllers;
using Orion.Services.Catalog.API.Services;
using Orion.Services.Intefaces;
using Xunit;

namespace Orion.Services.Catalog.API.Tests.Controllers;

[TestSubject(typeof(ProductController))]
public class ProductControllerTests
{
    private readonly Mock<ICatalogServices> _serviceMock;
    private readonly ProductController _controller;

    public ProductControllerTests()
    {
        _serviceMock = new Mock<ICatalogServices>();
        _controller = new ProductController(_serviceMock.Object);
    }

    [Fact(Skip = "Need to fix")]
    public async Task GetAllProducts_ReturnsOk()
    {
        // var product = new Core.Catalog.Domain.Product { Id = Guid.NewGuid() };
        // _serviceMock.Setup(s => s.GetAllAsync()).ReturnsAsync(product);
        //
        // var result = await _controller.GetAllProducts();
        //
        // var okResult = Assert.IsType<OkObjectResult>(result);
        // Assert.NotNull(okResult.Value);
    }

    [Fact]
    public async Task GetProductById_ReturnsOk_WhenFound()
    {
        
        var id = Guid.NewGuid();
        _serviceMock.Setup(s => s.GetByIdAsync(id)).ReturnsAsync(new Core.Catalog.Domain.Product { Id = id });

        var result = await _controller.GetProductById(id);

        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(id, ((Core.Catalog.Domain.Product)okResult.Value).Id);
    }

    [Fact]
    public async Task GetProductById_ReturnsNotFound_WhenNull()
    {
        var product = new Core.Catalog.Domain.Product { Id = Guid.NewGuid() };
        _serviceMock.Setup(s => s.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync((Core.Catalog.Domain.Product)null);

        var result = await _controller.GetProductById(Guid.NewGuid());

        Assert.IsType<NotFoundResult>(result);
    }

    [Fact]
    public async Task Create_ReturnsCreatedAt()
    {
        var product = new Core.Catalog.Domain.Product { Id = Guid.NewGuid() };
        _serviceMock.Setup(s => s.AddAsync(product)).ReturnsAsync(product);

        var result = await _controller.Create(product);

        var created = Assert.IsType<CreatedAtActionResult>(result);
        Assert.Equal(nameof(ProductController.GetProductById), created.ActionName);
    }

    [Fact]
    public async Task Update_ReturnsBadRequest_WhenIdMismatch()
    {
        var id = Guid.NewGuid();
        var product = new Core.Catalog.Domain.Product { Id = Guid.NewGuid() };

        var result = await _controller.Update(id, product);

        Assert.IsType<BadRequestObjectResult>(result);
    }

    [Fact]
    public async Task Update_ReturnsOk_WhenValid()
    {
        var id = Guid.NewGuid();
        var product = new Core.Catalog.Domain.Product { Id = id };
        _serviceMock.Setup(s => s.UpdateAsync(product)).ReturnsAsync(product);

        var result = await _controller.Update(id, product);

        var ok = Assert.IsType<OkObjectResult>(result);
        Assert.Equal(product, ok.Value);
    }

    [Fact]
    public async Task Delete_ReturnsNoContent()
    {
        var id = Guid.NewGuid();
        _serviceMock.Setup(s => s.DeleteAsync(id)).Returns(Task.CompletedTask);

        var result = await _controller.Delete(id);

        Assert.IsType<NoContentResult>(result);
    }
}
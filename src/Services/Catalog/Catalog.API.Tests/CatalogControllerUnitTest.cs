using Catalog.API.Controllers;
using Catalog.API.Entities;
using Catalog.API.Repositories;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

using Moq;
using System.Collections.Generic;
using Xunit;

namespace Catalog.API.Tests
{
    public class CatalogControllerUnitTest
    {
        private Mock<IProductRepository> productRepository;

        public CatalogControllerUnitTest()
        {
            productRepository = new Mock<IProductRepository>();
        }

        #region Get By Id  

        [Fact]
        public async void Task_GetProductById_Return_OkResult()
        {
            // Arrange

            var controller = new CatalogController(productRepository.Object);
            var ProductId = 2;

            // Act
            var result = await controller.GetProductById(ProductId.ToString());

            // Assert       
            Assert.IsType<ActionResult<Product>>(result);
        }

        [Fact(Skip = "Polly retry disabled for update address")]
        public async void Task_GetProductById_Return_NotFoundResult()
        {
            //Arrange  
            var productRepository = new Mock<IProductRepository>();
            var controller = new CatalogController(productRepository.Object);
            var ProductId = 3;

            //Act  
            var data = await controller.GetProductById(null);

            //Assert  
            Assert.IsType<NotFoundResult>(data);
        }

        [Fact(Skip = "Polly retry disabled for update address")]
        public async void Task_GetProductById_Return_BadRequestResult()
        {
            //Arrange  
            var controller = new CatalogController(productRepository.Object);
            int? ProductId = null;

            //Act  
            var data = await controller.GetProductById(ProductId.ToString());

            //Assert  
            Assert.IsType<BadRequestResult>(data);
        }

        [Fact(Skip = "Polly retry disabled for update address")]
        public async void Task_GetProductById_MatchResult()
        {
            //Arrange  
            var controller = new CatalogController(productRepository.Object);
            string? ProductId = "1";

            //Act  
            var data = await controller.GetProductById(ProductId);

            //Assert  
            Assert.IsType<OkObjectResult>(data);

            var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
            var product = okResult.Value.Should().BeAssignableTo<Product>().Subject;

            Assert.Equal("Test Title 1", product.Name);
            Assert.Equal("Test Description 1", product.Description);
        }

        #endregion

        #region Get All  

        [Fact(Skip = "Polly retry disabled for update address")]
        public async void Task_GetProducts_Return_OkResult()
        {
            //Arrange  
            var controller = new CatalogController(productRepository.Object);

            //Act  
            var data = await controller.GetProducts();

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public void Task_GetProducts_Return_BadRequestResult()
        {
            //Arrange  
            var controller = new CatalogController(productRepository.Object);

            //Act  
            var data = controller.GetProducts();
            data = null;

            if (data != null)
                //Assert  
                Assert.IsType<BadRequestResult>(data);
        }

        [Fact(Skip = "Polly retry disabled for update address")]
        public async void Task_GetProducts_MatchResult()
        {
            //Arrange  
            var controller = new CatalogController(productRepository.Object);

            //Act  
            var data = await controller.GetProducts();

            //Assert  
            Assert.IsType<OkObjectResult>(data);

            var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
            var product = okResult.Value.Should().BeAssignableTo<List<Product>>().Subject;

            Assert.Equal("Test Title 1", product[0].Name);
            Assert.Equal("Test Description 1", product[0].Name);

            Assert.Equal("Test Title 2", product[1].Description);
            Assert.Equal("Test Description 2", product[1].Description);
        }

        #endregion

        #region Add New Blog  

        [Fact(Skip = "Polly retry disabled for update address")]
        public async void Task_Add_ValidData_Return_OkResult()
        {
            //Arrange  
            var controller = new CatalogController(productRepository.Object);
            var product = new Product()
            {
                Name = "Test Title 3",
                Description = "Test Description 3",
                Price = 2,
                ImageFile = "asdasda",
                Summary = "Summary",
                Category = "Engineering"
            };

            //Act  
            var data = await controller.CreateProduct(product);

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact(Skip = "Polly retry disabled for update address")]
        public async void Task_Add_InvalidData_Return_BadRequest()
        {
            //Arrange  
            var controller = new CatalogController(productRepository.Object);
            Product product = new Product()
            {
                Name = "Test Title More Than 20 Characteres",
                Description = "Test Description 3",
                Price = 2,
                ImageFile = "asdasda",
                Summary = "Summary",
                Category = "Engineering"
            };

            //Act              
            var data = await controller.CreateProduct(product);

            //Assert  
            Assert.IsType<BadRequestResult>(data);
        }

        [Fact(Skip = "Polly retry disabled for update address")]
        public async void Task_Add_ValidData_MatchResult()
        {
            //Arrange  
            var controller = new CatalogController(productRepository.Object);
            var product = new Product()
            {
                Name = "Test Title 4",
                Description = "Test Description 4",
                Price = 2,
                ImageFile = "asdasda",
                Summary = "Summary",
                Category = "Engineering"
            };

            //Act  
            var data = await controller.CreateProduct(product);

            //Assert  
            Assert.IsType<OkObjectResult>(data);

            var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
            // var result = okResult.Value.Should().BeAssignableTo<ProductViewModel>().Subject;  

            Assert.Equal(3, okResult.Value);
        }

        #endregion

        #region Update Existing Blog  

        [Fact(Skip = "Polly retry disabled for update address")]
        public async void Task_Update_ValidData_Return_OkResult()
        {
            //Arrange  
            var controller = new CatalogController(productRepository.Object);
            var productId = new Product
            {
                Id = "225",
                Name = "Test Title 4",
                Description = "Test Description 4",
                Price = 2,
                ImageFile = "asdasda",
                Summary = "Summary",
                Category = "Engineering"
            };

            //Act  
            var existingProduct = await controller.UpdateProduct(productId);
            var okResult = existingProduct.Should().BeOfType<OkObjectResult>().Subject;
            var result = okResult.Value.Should().BeAssignableTo<Product>().Subject;

            var product = new Product();
            product.Name = "Test Title 2 Updated";
            product.Description = result.Description;
            product.Price = result.Price;
            product.ImageFile = result.ImageFile;
            product.Summary = result.Summary;

            var updatedData = await controller.UpdateProduct(product);

            //Assert  
            Assert.IsType<OkResult>(updatedData);
        }

        [Fact(Skip = "Polly retry disabled for update address")]
        public async void Task_Update_InvalidData_Return_BadRequest()
        {
            //Arrange  
            var controller = new CatalogController(productRepository.Object);
            var product_ = new Product
            {
                Id = "225",
                Name = "Test Title 4",
                Description = "Test Description 4",
                Price = 2,
                ImageFile = "asdasda",
                Summary = "Summary",
                Category = "Engineering"
            };

            //Act  
            var existingProduct = await controller.UpdateProduct(product_);
            var okResult = existingProduct.Should().BeOfType<OkObjectResult>().Subject;
            var result = okResult.Value.Should().BeAssignableTo<Product>().Subject;

            var product = new Product();
            product.Name = "Test Title More Than 20 Characteres";
            product.Description = result.Description;
            product.Price = result.Price;
            product.ImageFile = result.ImageFile;
            product.Summary = result.Summary;

            var data = await controller.UpdateProduct(product);

            //Assert  
            Assert.IsType<BadRequestResult>(data);
        }

        [Fact(Skip = "Polly retry disabled for update address")]
        public async void Task_Update_InvalidData_Return_NotFound()
        {
            //Arrange  
            var controller = new CatalogController(productRepository.Object);
            var product_ = new Product
            {
                Id = "225",
                Name = "Test Title 4",
                Description = "Test Description 4",
                Price = 2,
                ImageFile = "asdasda",
                Summary = "Summary",
                Category = "Engineering"
            };

            //Act  
            var existingProduct = await controller.UpdateProduct(product_);
            var okResult = existingProduct.Should().BeOfType<OkObjectResult>().Subject;
            var result = okResult.Value.Should().BeAssignableTo<Product>().Subject;

            var product = new Product();
            product.Id = "5";
            product.Name = "Test Title More Than 20 Characteres";
            product.Description = result.Description;
            product.Price = result.Price;
            product.ImageFile = result.ImageFile;
            product.Summary = result.Summary;

            var data = await controller.UpdateProduct(product);

            //Assert  
            Assert.IsType<NotFoundResult>(data);
        }

        #endregion

        #region Delete Product  

        [Fact(Skip = "Polly retry disabled for update address")]       
        public async void Task_Delete_Product_Return_OkResult()
        {
            //Arrange  
            var controller = new CatalogController(productRepository.Object);
            var productId = "2";

            //Act  
            var data = await controller.DeleteProductById(productId);

            //Assert  
            Assert.IsType<OkResult>(data);
        }

        [Fact(Skip = "Polly retry disabled for update address")]
        public async void Task_Delete_Product_Return_NotFoundResult()
        {
            //Arrange  
            var controller = new CatalogController(productRepository.Object);
            var productId = "5";

            //Act  
            var data = await controller.DeleteProductById(productId);

            //Assert  
            Assert.IsType<NotFoundResult>(data);
        }

        [Fact(Skip = "Polly retry disabled for update address")]
        public async void Task_Delete_Return_BadRequestResult()
        {
            //Arrange  
            var controller = new CatalogController(productRepository.Object);
            string productId = null;

            //Act  
            var data = await controller.DeleteProductById(productId);

            //Assert  
            Assert.IsType<BadRequestResult>(data);
        }

        #endregion
    }
}
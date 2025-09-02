using Microsoft.AspNetCore.Mvc;
using Orion.Domain.IRepositories;

namespace Orion.API.Catalog.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ICatalogServices _service;

        public ProductController(ICatalogServices service)
        {
            _service = service;
        }

        /// <summary>Get all products.</summary>
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        /// <summary>Get a product by ID.</summary>
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {     throw new NotImplementedException();
            // object? result = await _service.GetByIdAsync(id);
            // if (result == null) return NotFound();
            // return Ok(result);
        }

        /// <summary>Create a product.</summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            var result =  _service.AddAsync(product);
            var id =  result.Id;
            return CreatedAtAction(nameof(GetProductById), new { id = result.Id }, result);
        }

        /// <summary>Update a product.</summary>
        [HttpPut("{id:guid}")]
        public async Task<IActionResult?> Update(Guid id, [FromBody] Product product)
        {
            if (id != product.Id) return BadRequest("Product ID mismatch.");
          await _service.UpdateAsync(product);
            return null;
        }

        /// <summary>Delete a product.</summary>
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    
    }
}
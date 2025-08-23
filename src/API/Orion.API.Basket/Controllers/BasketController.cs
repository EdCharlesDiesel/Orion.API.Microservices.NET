using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Orion.API.Basket.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BasketController(IBasketService service) : ControllerBase
    {
        private readonly IBasketService _service = service;

        /// <summary>
        /// Get all baskets.
        /// </summary>
        [HttpGet]
        public Task<IActionResult> GetAllBaskets()
        {
            var result = _service.GetAll();
            return Task.FromResult<IActionResult>(Ok(result));
        }

        /// <summary>
        /// Create a new basket.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateBasket([FromBody] DataAccess.Postgres.Entities.Basket basket)
        {
            throw new NotImplementedException();
            // var dto = mapper.Map<BasketDto>(basket);
            // var result = _service.CreateBasketAll(basket);
            // return CreatedAtAction(nameof(GetBasketById), new { id = result.Id }, result);
        }


        /// <summary>
        /// Get a basket by ID.
        /// </summary>
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetBasketById(Guid id)
        {
            throw new NotImplementedException();
            // var result = await service.GetByIdAsync(id);
            // if (result == null)
            //     return NotFound();
            //
            // return Ok(result);
        }


        /// <summary>
        /// Update an existing basket.
        /// </summary>
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateBasket(Guid id, [FromBody] DataAccess.Postgres.Entities.Basket basket)
        {
            throw new NotImplementedException();
            // if (id != basket.Id)
            //     return BadRequest("ID mismatch.");
            //
            // var dto = mapper.Map<BasketDto>(basket);
            // var updated = await service.UpdateAsync(dto);
            // return Ok(updated);
        }

        /// <summary>
        /// Partially update a basket (e.g. patch one or two fields).
        /// </summary>
        [HttpPatch("{id:guid}")]
        public async Task<IActionResult> PatchBasket(Guid id,
            [FromBody] JsonPatchDocument<DataAccess.Postgres.Entities.Basket> patchDoc)
        {
            throw new NotImplementedException();
            // if (patchDoc == null) return BadRequest();
            //
            // var basket = await service.GetByIdAsync(id);
            // if (basket == null) return NotFound();
            //
            // patchDoc.ApplyTo(basket, ModelState);
            // if (!ModelState.IsValid) return BadRequest(ModelState);
            //
            // var dto = mapper.Map<BasketDto>(basket);
            // object? result = await service.UpdateAsync(dto);
            // return Ok(result);
        }

        /// <summary>
        /// Delete a basket by ID.
        /// </summary>
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteBasket(Guid id)
        {
            throw new NotImplementedException();
            // await service.DeleteAsync(id);
            // return NoContent();
        }
    }

    public interface IBasketService
    {
        object? GetAll();
        object? CreateBasketAll(DataAccess.Postgres.Entities.Basket basket);
    }
}
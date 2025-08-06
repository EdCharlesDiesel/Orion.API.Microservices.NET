using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Orion.Services.Intefaces;


namespace Orion.API.Basket.Controllers
{ 
[ApiController]
[Route("api/[controller]")]
public class BasketController(IBasketServices service, IMapper mapper) : ControllerBase
{
    /// <summary>
    /// Get all baskets.
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetAllBaskets()
    {
        var result = await service.GetAllAsync();
        return Ok(result);
    }

    /// <summary>
    /// Get a basket by ID.
    /// </summary>
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetBasketById(Guid id)
    {
        var result = await service.GetByIdAsync(id);
        if (result == null)
            return NotFound();

        return Ok(result);
    }

    /// <summary>
    /// Create a new basket.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> CreateBasket([FromBody] Core.Basket.Domain.Basket basket)
    {
        throw new NotImplementedException();
        // var dto = mapper.Map<BasketDto>(basket);
        // var result = await service.AddAsync(dto);
        // return CreatedAtAction(nameof(GetBasketById), new { id = result.Id }, result);
    }

    /// <summary>
    /// Update an existing basket.
    /// </summary>
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateBasket(Guid id, [FromBody] Core.Basket.Domain.Basket basket)
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
    public async Task<IActionResult> PatchBasket(Guid id, [FromBody] JsonPatchDocument<Core.Basket.Domain.Basket> patchDoc)
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
        await service.DeleteAsync(id);
        return NoContent();
    }
}


}
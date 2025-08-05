using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Orion.Services.Order.API.DTO;
using Orion.Services.Order.API.Services;

namespace Orion.Services.Order.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OrderController(IOrderServices service) : ControllerBase
    {
        /// <summary>
        /// Get all orders.
        /// </summary>
        [HttpGet]
        public async Task<OkObjectResult> GetAllOrders()
        {
            var result = await service.GetAllAsync();

            return Ok(result);
        }

        /// <summary>
        /// Create's an order.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost("creat")]
        public async Task<IActionResult> Create([FromQuery] Core.Order.Domain.Order order)
        {
            // var profileToDatabase = mapper.Map<Core.Order.Domain.Order>(profile);
            var result = await service.AddAsync(order);
            return Ok(result);
        }

        /// <summary>
        /// Update's an order.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPut("update")]
        public async Task<IActionResult> UpdateOrder([FromQuery] Core.Order.Domain.Order order)
        {
            var result = await service.UpdateAsync(order);
            return Ok(result);
        }

        /// <summary>
        /// Delete's an order by id.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [HttpDelete("delete")]
        public async Task<IActionResult> UpdateOrder(Guid orderId)
        {
            await service.DeleteAsync(orderId);
            return Ok();
        }
    }
}
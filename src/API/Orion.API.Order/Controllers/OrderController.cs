using Microsoft.AspNetCore.Mvc;
using Orion.Domain.IRepositories;

namespace Orion.API.Order.Controllers
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
        public async Task<IActionResult> Create([FromQuery] FastEndpoints.Order order)
        {
            // var profileToDatabase = mapper.Map<Core.Order.Domain.Order>(profile);
            await service.AddAsync(order);
            return Ok();
        }

        /// <summary>
        /// Update's an order.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPut("update")]
        public async Task<IActionResult> UpdateOrder([FromQuery] Core.Orders.Domain.Order order)
        {
             await service.UpdateAsync(order);
            return Ok();
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
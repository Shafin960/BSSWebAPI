using Core.Services;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace BSSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("datatable")]
        public Task<IEnumerable<OrderResource>> GetAll() => _orderService.GetAll();

        [HttpGet("get")]
        public Task<IEnumerable<OrderOptionsResource>> Get() => _orderService.Get();

        [HttpPost("create")]
        public async Task Create(SaveOrderResource newModel)
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            await _orderService.Create(newModel);
        }
        [HttpPut("update/{id}")]
        public async Task UdpateDesignation(Guid id, [FromBody] SaveOrderResource updatedModel)
        {
            var currentOrder = await _orderService.SingleOrDefaultAsync(id) ?? throw new Exception("Order not found");
            await _orderService.Update(currentOrder, updatedModel);
        }

        [HttpPut("update-status/{id}")]
        public async Task UdpateOrder(Guid id, [FromBody] OrderStatusVM updatedModel)
        {
            var existingFood = await _orderService.SingleOrDefaultAsync(id) ?? throw new Exception("Order not found");
            await _orderService.UpdateStatus(existingFood, updatedModel);
        }


        [HttpDelete("delete/{id}")]
        public async Task Delete(Guid id)
        {
            var employeeToDelete = await _orderService.SingleOrDefaultAsync(id) ?? throw new Exception("Food not found");
            await _orderService.Delete(employeeToDelete);
        }
    }
}
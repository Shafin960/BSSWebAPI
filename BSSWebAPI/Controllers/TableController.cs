using Core.Models;
using Core.Services;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace BSSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {

        private readonly ITableService _tableService;
        public TableController(ITableService tableService)
        {
            _tableService = tableService;
        }
        

        [HttpGet("get")]
        public Task<IEnumerable<TableOptionsResource>> Get() => _tableService.Get();

        [HttpGet("get/{id}")]

        public Task<TableResource> Get(int id) => _tableService.SingleOrDefaultAndSelectAsync(id);


        [HttpGet("datatable")]
        public Task<IEnumerable<TableResource>> GetAll() => _tableService.GetAll();

        [HttpPost("create")]
        public async Task<TableCreateResource> Create(TableCreateResource newModel)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }
            return await _tableService.Create(newModel);

        }

        [HttpDelete("delete/{id}")]
        public async Task Delete(int id)
        {
            var foodToDelete = await _tableService.SingleOrDefaultAsync(id) ?? throw new Exception("Food not found");
            await _tableService.Delete(foodToDelete);
        }

        [HttpPut("update/id")]

        public async Task UdpateFood(int id, [FromBody] TableCreateResource updatedModel)
        {
            var existingFood = await _tableService.SingleOrDefaultAsync(id) ?? throw new Exception("Food not found");
            await _tableService.Update(existingFood, updatedModel);
        }


    }
}

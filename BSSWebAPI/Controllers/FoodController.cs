using Core.Models;
using Core.Services;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace BSSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService foodService;
        public FoodController(IFoodService foodService)
        {
            this.foodService = foodService;
        }

        [HttpGet("get")]
        public Task<IEnumerable<FoodOptionsResource>> Get() => foodService.Get();

        [HttpGet("get/{id}")]
        public Task<FoodResource> Get(int id) => foodService.SingleOrDefaultAndSelectAsync(id);

        [HttpGet("datatable")]
        public Task<IEnumerable<GetFoodDataVM>> GetAll() => foodService.GetAll();

        [HttpPost("create")]
        public async Task<Food> Create(FoodResource newModel)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }
            return await foodService.Create(newModel);
        }

        [HttpDelete("delete/{id}")]
        public async Task Delete(int id)
        {
            var foodToDelete = await foodService.SingleOrDefaultAsync(id) ?? throw new Exception("Food not found");
            await foodService.Delete(foodToDelete);
        }

        [HttpPut("update/{id}")]

        public async Task UdpateFood(int id, [FromBody] UpdateFoodResource updatedModel)
        {
            var existingFood = await foodService.SingleOrDefaultAsync(id) ?? throw new Exception("Food not found");
            await foodService.Update(existingFood, updatedModel);
        }

    }
}


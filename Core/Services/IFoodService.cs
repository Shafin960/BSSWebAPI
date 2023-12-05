using Core.Models;
using Core.ViewModels;

namespace Core.Services
{
    public interface IFoodService
    {
        Task<IEnumerable<FoodOptionsResource>> Get();
        Task<IEnumerable<GetFoodDataVM>> GetAll();
        Task<Food> SingleOrDefaultAsync(int id);
        Task<FoodResource> SingleOrDefaultAndSelectAsync(int id);
        Task<Food> Create(FoodResource newModel);
        Task<IEnumerable<Food>> CreateRange(IEnumerable<Food> newModels);
        Task Update(Food modelToBeUpdated, UpdateFoodResource model);
        Task Delete(Food model);
    }
}

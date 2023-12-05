using Core;
using Core.Models;
using Core.Services;
using Core.ViewModels;

namespace Services
{
    public class FoodService : IFoodService
    {
        private readonly IUnitOfWork<Food> _food;
        
        public FoodService(IUnitOfWork<Food> food)
        {
            _food = food;
            
        }

        public async Task<Food> Create(FoodResource newModel)
        {

            var food = new Food
            {
                Name = newModel.Name,
                Description = newModel.Description,
                Price = newModel.Price,
                DiscountType = newModel.DiscountType,
                Discount = newModel.Discount,
                DiscountPrice = newModel.DiscountPrice,
                Image = newModel.Base64,

            };
            await _food.Entity.AddAsync(food);
            _food.Commit();
            return food;
        }

        public async Task<IEnumerable<Food>> CreateRange(IEnumerable<Food> newModels)
        {
            await _food.Entity
                 .AddRangeAsync(newModels);
            _food.Commit();
            return newModels;
        }


        public async Task Delete(Food model)
        {
            _food.Entity.Remove(model);
            await _food.CommitAsync();
        }

        public async Task<IEnumerable<FoodOptionsResource>> Get()
        {
            return await _food.Entity.GetAndSelectAsync(it => new FoodOptionsResource
            {
                FoodId = it.Id,
                Name = it.Name
            });
        }

        public async Task<Food> SingleOrDefaultAsync(int id) => await _food.Entity.SingleOrDefaultAsync(id);
        public async Task<FoodResource> SingleOrDefaultAndSelectAsync(int id) => await _food.Entity.SingleOrDefaultAndSelectAsync(
            it => new FoodResource
            {
                
                Name = it.Name,
                Description = it.Description,
                Discount = it.Discount,
                DiscountPrice = it.DiscountPrice,
                DiscountType = it.DiscountType,
                Image = it.Image,
                Price = it.Price,
            },
            it => it.Id == id
            );

        public async Task Update(Food modelToBeUpdated, UpdateFoodResource model)
        {
            modelToBeUpdated.Name = model.Name;
            modelToBeUpdated.Description = model.Description;
            modelToBeUpdated.Price = model.Price;
            modelToBeUpdated.DiscountPrice = model.DiscountPrice;
            modelToBeUpdated.Discount = model.Discount;
            modelToBeUpdated.DiscountType = model.DiscountType;
            await _food.CommitAsync();
        }

        public async Task<IEnumerable<GetFoodDataVM>> GetAll()
        {
            return await _food.Entity.GetAndSelectAsync(it => new GetFoodDataVM
            {
                Id= it.Id,
                Name = it.Name,
                Description = it.Description,
                Price = it.Price,
                DiscountType = (it.DiscountType).ToString(),
                Image = it.Image,
                Discount = it.Discount,
                DiscountPrice=it.DiscountPrice,

            }) ;
        }
    }
}

using Core.Models;
using Core.ViewModels;

namespace Core.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderOptionsResource>> Get();

        Task<IEnumerable<OrderResource>> GetAll();
        Task<Order> Create(SaveOrderResource newModel);
        Task<Order> SingleOrDefaultAsync(Guid id);

        Task Update(Order modelToBeUpdated, SaveOrderResource model);
        Task UpdateStatus(Order modelToBeUpdated, OrderStatusVM model);

        Task Delete(Order model);

    }
}

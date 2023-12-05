using Core.Models;
using Core.ViewModels;

namespace Core.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderOptionsResource>> Get();

        Task<Order> Create(SaveOrderResource newModel);
        Task<Order> SingleOrDefaultAsync(Guid id);

        Task Update(Order modelToBeUpdated, SaveOrderResource model);

        Task Delete(Order model);

    }
}

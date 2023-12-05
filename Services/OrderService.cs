using Core;
using Core.Models;
using Core.Services;
using Core.ViewModels;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork<Order> _order;
        private readonly IUnitOfWork<OrderItem> _orderItem;
        public OrderService(IUnitOfWork<Order> order, IUnitOfWork<OrderItem> orderItem)
        {
            _order = order;
            _orderItem = orderItem;

        }


        public async Task<IEnumerable<OrderOptionsResource>> Get()
        {
            return await _order.Entity.GetAndSelectAsync(it => new OrderOptionsResource
            {
                OrderId = it.Id,
                OrderNumber = it.OrderNumber
            });
        }

        public async Task<Order> Create(SaveOrderResource newModel)
        {
            var order = new Order
            {
                TableId = newModel.TableId,
                OrderNumber= newModel.OrderNumber,
                Amount=newModel.Amount, 
            };
            await _order.Entity.AddAsync(order);
            _order.Commit();

            var orderItems = new List<OrderItem>();
            foreach (var item in newModel.Items)
            {
                orderItems.Add(new OrderItem
                {
                    FoodId = item.FoodId,
                    FoodPackageId = item.FoodPackageId,
                    Quantity=item.Quantity,
                    UnitPrice= item.UnitPrice,
                    TotalPrice= item.TotalPrice,
                });
            }
            await _orderItem.Entity.AddRangeAsync(orderItems);
            _orderItem.Commit();
            return order;
        }

        public async Task Update(Order modelToBeUpdated, SaveOrderResource model)
        {
            modelToBeUpdated.TableId= model.TableId;
            modelToBeUpdated.OrderNumber = model.OrderNumber;
            modelToBeUpdated.Amount = model.Amount;
            modelToBeUpdated.OrderItems = (ICollection<OrderItem>)model.Items;
            await _order.CommitAsync();
        }

        public async Task<Order> SingleOrDefaultAsync(Guid id)=>await _order.Entity.SingleOrDefaultAsync(id);

        public async Task Delete(Order model)
        {
            _order.Entity.Remove(model);
            await _order.CommitAsync();
        }
    }
}

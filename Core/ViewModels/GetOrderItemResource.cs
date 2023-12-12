using Core.Enums;

namespace Core.ViewModels
{
    public class GetOrderItemResource
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public decimal Amount { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime OrderTime { get; set; }
        public TableResource Table {  get; set; }
        
    }
}

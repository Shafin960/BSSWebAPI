using Core.Enums;

namespace Core.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public decimal Amount { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime OrderTime { get; set; }
        public Guid? OrderTakenById { get; set; }
        public Guid? OrderedById { get; set; }
        public int TableId { get; set; }

        public Table Table { get; set; }
        public ApplicationUser OrderTakenBy { get; set; }
        public ApplicationUser OrderedBy { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}

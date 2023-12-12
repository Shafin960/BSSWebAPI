using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;

namespace Core.ViewModels
{
    public class OrderResource
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public decimal Amount { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime OrderTime { get; set; }
        public TableResource Table { get; set; }
        public List<OrderItemResource> OrderItems { get; set; }


    }
}

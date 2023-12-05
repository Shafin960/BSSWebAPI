using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class SaveOrderResource
    {
        public int TableId { get; set; }
        public string OrderNumber { get; set; }
        public decimal Amount { get; set; }
        public string PhoneNumber { get; set; }
        public List<SaveOrderItemResource> Items { get; set; }
    }
}

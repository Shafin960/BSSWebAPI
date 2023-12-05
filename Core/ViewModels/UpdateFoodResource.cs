using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;

namespace Core.ViewModels
{
    public class UpdateFoodResource
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DiscountType DiscountType { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountPrice { get; set; }
    }
}

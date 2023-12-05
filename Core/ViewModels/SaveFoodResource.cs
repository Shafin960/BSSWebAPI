using Core.Enums;

namespace Core.ViewModels
{
    public class SaveFoodResource
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DiscountType DiscountType { get; set; }
        public decimal Discount {  get; set; }
        public decimal DiscountPrice { get; set; }
        public string Image {  get; set; }
    }
}

using Core.Enums;

namespace Core.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set;}
        public DiscountType DiscountType { get; set;}
        public decimal Discount {  get; set;}
        public decimal DiscountPrice { get; set; }
        public string Image {  get; set; }

        public virtual ICollection<FoodPackage> FoodPackages { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }

    }
}

namespace Core.Models
{
    public class FoodPackage
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public int PackageId { get; set; }
        public decimal Quantity { get; set; }

        public Food Food { get; set; }
        public Package Package { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}

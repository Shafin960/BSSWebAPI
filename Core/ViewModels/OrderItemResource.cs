namespace Core.ViewModels
{
    public class OrderItemResource
    {
        public Guid Id { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public FoodResource Food { get; set; }
        public FoodPackageResource FoodPackage { get; set; }
    }
}

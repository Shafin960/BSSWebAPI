namespace Core.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; } = new Guid("42672dae-532c-4650-8bb7-d82e94d24a40");
        public Guid OrderId { get; set; }
        public int FoodId { get; set; }
        public int? FoodPackageId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public Order Order { get; set; }
        public Food Food { get; set; }
        public FoodPackage FoodPackage { get; set; }

    }
}

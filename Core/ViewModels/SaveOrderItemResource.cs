namespace Core.ViewModels
{
    public class SaveOrderItemResource
    {
        public int FoodId { get; set; }
        public int FoodPackageId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

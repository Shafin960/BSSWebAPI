namespace Core.Models
{
    public class Division
    {
        public int Id { get; set; }
        public string DivisionName { get; set; }
        public int CountryId { get; set; }

        public ICollection<District> Districts { get; set; }
        public Country Country { get; set; }
    }
}

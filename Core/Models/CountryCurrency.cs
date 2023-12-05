namespace Core.Models
{
    public class CountryCurrency
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int CurrencyId { get; set; }
        public Country Country { get; set; }
        public Currency Currency { get; set; }
    }
}

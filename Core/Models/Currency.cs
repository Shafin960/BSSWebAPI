namespace Core.Models
{
    public class Currency
    {
        public int Id { get; set; }
        public string CurrencyName { get; set; }
        public string Code { get; set; }
        public int Number { get; set; }
        public virtual ICollection<CountryCurrency> CountryCurrencies { get; set; }
    }
}

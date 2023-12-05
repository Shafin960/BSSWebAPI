namespace Core.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set;}
        public int Numeric { get; set;}
        public string Capital { get; set;}
        public virtual ICollection<CountryCurrency> CountryCurrencies { get; set; }
    }
}

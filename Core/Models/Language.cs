namespace Core.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string LanguageName { get; set; }
        public string ISO1Codes { get; set; }
        public string ISO2Code { get; set; }

        public virtual ICollection<CountryLanguage> CountryLanguages { get; set;}
    }
}

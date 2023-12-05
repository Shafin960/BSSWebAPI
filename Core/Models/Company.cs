namespace Core.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNameBn { get; set;}
        public string NBRRegistrationNo { get; set; }
        public string ContactPerson { get; set; }
        public string Mobile { get; set;}
        public string City { get; set; }
        public string Address { get; set; }
        public string BIN { get; set; }
        public string OldBIN { get; set; }
        public string ETIN { get; set; }
        public string TradeLicense { get; set; }
        public DateTime ActivatedDate { get; set; }
        public DateTime IssuedDate { get; set; }
        public string BusinessNature { get; set; }
        public string Description { get; set;}
        public string DescriptionBn { get; set; }
        public string EconomicActivities { get; set; }
        public string Identifier { get;set; }
        public string DatabaseType { get; set; }
        public string ConnectionString { get; set;}
        public string ApplicationName { get; set;}
        public string ClientName { get; set; }



        public virtual ICollection<ApplicationUser>  ApplicationUsers { get; set; }
    }
}

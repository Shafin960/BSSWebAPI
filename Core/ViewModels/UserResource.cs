namespace Core.ViewModels
{
    public class UserResource
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; }
        public string NID { get; set; }
        public DateTime? NIDVerifiedDate { get; set; }
        public DateTime? LastSeenDate { get; set; }
        public Guid? NIDVerifiedBy { get; set; }
        public DateTime DOB { get; set; }
        public int GenderId { get; set; }
        public int? CompanyId { get; set; }
        public string Image { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Github { get; set; }
        public string Label { get; set; }
        public string ExistingImage { get; set; }
        public string GenderName { get; set; }
    }
}

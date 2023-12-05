using System.Diagnostics;

namespace Core.ViewModels
{
    public class SaveEmployeeResource
    {   
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }      
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; }
        public string NID { get; set; }
        public DateTime DOB { get; set; }
        public DateTime JoinDate { get; set; }
        public int GenderId { get; set; }      
        public string Designantion {  get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Image {  get; set; }
        public string Base64 { get; set; }

    }
}

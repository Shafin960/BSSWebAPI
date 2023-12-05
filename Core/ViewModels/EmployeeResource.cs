using Core.Models;

namespace Core.ViewModels
{
    public class EmployeeResource
    {
        public Guid Id { get; set; }
        public string Designation {  get; set; }
        public DateTime JoinDate { get; set; }
        public  decimal? AmountSold { get; set; }
        public ApplicationUser User { get; set; }
    }
}

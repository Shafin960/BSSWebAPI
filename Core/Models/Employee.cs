namespace Core.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Designation { get; set; }
        public Guid UserId { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal? AmountSold { get; set; }
        public Guid InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }

        public ApplicationUser User { get; set; }
        public virtual ICollection<EmployeeTable> EmployeeTables { get; set; }

    }
}

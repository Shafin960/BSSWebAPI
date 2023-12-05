namespace Core.Models
{
    public class EmployeeTable
    {
        public int Id { get; set; }
        public Guid EmployeeId { get; set; }
        public int TableId { get; set; }

        public Employee Employee { get; set; }
        public Table Table { get; set; }
    }
}

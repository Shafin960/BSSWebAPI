namespace Core.ViewModels
{
    public class EmployeeTableOptionsResource
    {
        public int EmployeeTableId { get; set; }
        public EmployeeOptionsResource Employee {  get; set; }
        public TableOptionsResource Table {  get; set; }
    }
}

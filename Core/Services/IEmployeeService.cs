using Core.Models;
using Core.ViewModels;

namespace Core.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeOptionsResource>> Get();
        Task<IEnumerable<EmployeeOptionsResource>> NonAssignedAsync(int tableId);
        Task<IEnumerable<GetEmployeeVM>> GetAll();
        Task<Employee> Create(SaveEmployeeResource newModel);
        Task<EmployeeResource> SingleOrDefaultAndSelectAsync(Guid id);
        Task<Employee> SingleOrDefaultAsync(Guid id);
        Task Update(Employee modelToBeUpdated, UpdateEmployeeResource model);
        Task Delete(Employee model);
    }
}

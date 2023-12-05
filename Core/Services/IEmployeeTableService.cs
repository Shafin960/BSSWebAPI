using Core.Models;
using Core.ViewModels;

namespace Core.Services
{
    public interface IEmployeeTableService
    {
        Task<IEnumerable<EmployeeTableOptionsResource>> Get();
        Task<EmployeeTable> Create(SaveEmployeeTableResource newModel);
        Task<IEnumerable<EmployeeTable>> CreateMultiple(List<SaveEmployeeTableResource> newModel);
        Task<EmployeeTable> SingleOrDefaultAsync(int id);
        Task<EmployeeTableOptionsResource> SingleOrDefaultAndSelectAsync(int id);
        Task Update(EmployeeTable modelToBeUpdated, SaveEmployeeTableResource model);
        Task Delete(EmployeeTable model);

    }
}

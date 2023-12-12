using Core.Models;
using Core.ViewModels;

namespace Core.Services
{
    public interface ITableService
    {
        Task<IEnumerable<TableOptionsResource>> Get();
        Task<IEnumerable<TableResource>> GetAll();
        Task<TableCreateResource> Create(TableCreateResource newModel);
        Task<Table> SingleOrDefaultAsync(int id);
        Task<TableResource> SingleOrDefaultAndSelectAsync(int id);
        Task Update(Table modelToBeUpdated, TableCreateResource model);
        Task Delete(Table model);
    }
}

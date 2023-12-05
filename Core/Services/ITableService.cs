using Core.Models;
using Core.ViewModels;

namespace Core.Services
{
    public interface ITableService
    {
        Task<IEnumerable<TableOptionsResource>> Get();
        Task<TableResource> Get(int id);
        Task<IEnumerable<TableResource>> GetAll();
        Task<TableCreateResource> Create(TableCreateResource newModel);
        Task<Table> SingleOrDefaultAsync(int id);
        Task<TableCreateResource> SingleOrDefaultAndSelectAsync(int id);
        Task Update(Table modelToBeUpdated, TableCreateResource model);
        Task Delete(Table model);
    }
}

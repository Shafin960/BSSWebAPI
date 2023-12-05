using Core.Models;
using Core;
using Core.Services;
using Core.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Services
{
    public class TableService : ITableService
    {
        private readonly IUnitOfWork<Core.Models.Table> _table;
        private readonly IUnitOfWork<EmployeeTable> _employeeTable;

        public TableService(IUnitOfWork<Core.Models.Table> table, IUnitOfWork<EmployeeTable> employeeTable)
        {
            _table = table;
            _employeeTable = employeeTable;

        }

        public async Task<TableCreateResource> Create(TableCreateResource newModel)
        {
            var table = new Core.Models.Table
            {
                TableNumber = newModel.TableNumber,
                NumberOfSeats = newModel.NumberOfSeats,
                Image = newModel.Base64,
                IsOccupied = true,

            };
            await _table.Entity.AddAsync(table);
            _table.Commit();
            return newModel;
        }

        public async Task Delete(Core.Models.Table model)
        {
            _table.Entity.Remove(model);
            await _table.CommitAsync();
        }

        public async Task<IEnumerable<TableOptionsResource>> Get()
        {
            return await _table.Entity.GetAndSelectAsync(it => new TableOptionsResource
            {
                TableId = it.Id,
                TableNumber = it.TableNumber,
                
            }) ;
        }

        public async Task<TableResource> Get(int id)
        {
            var table = await _table.Entity.SingleOrDefaultAsync(it => it.Id == id);
            if (table == null)
            {
                return null;
            }
            var getTableById = new TableResource
            {
                Id = id,
                TableNumber = table.TableNumber,
                Image = table.Image,
                IsOccupied=table.IsOccupied,
                Employees = table.EmployeeTables.Select(e => new EmployeeWithTableIdResource
                {
                    EmployeeTableId = e.TableId,
                    EmployeeId = e.EmployeeId,
                    Name = e.Employee.User.FullName,
                }).ToList()
            };
           
            return getTableById;

        }

        public async Task<IEnumerable<TableResource>> GetAll()
        {
            return await _table.Entity.GetAndSelectAsync(it => new TableResource
            {
                Id = it.Id,
                TableNumber = it.TableNumber,
                Image = it.Image,
                IsOccupied = it.IsOccupied,
                NumberOfSeats=it.NumberOfSeats,
                Employees = it.EmployeeTables.Select(e => new EmployeeWithTableIdResource
                {
                    EmployeeTableId = e.TableId,
                    EmployeeId = e.EmployeeId,
                    Name = e.Employee.User.FullName,
                }).ToList()

            });
        }

        public async Task<TableCreateResource> SingleOrDefaultAndSelectAsync(int id) => await _table.Entity.SingleOrDefaultAndSelectAsync(
            it => new TableCreateResource
            {
               TableNumber = it.TableNumber,
            },
            it => it.Id == id
            );

        public async Task<Core.Models.Table> SingleOrDefaultAsync(int id)  => await _table.Entity.SingleOrDefaultAsync(id);

        public async Task Update(Core.Models.Table modelToBeUpdated, TableCreateResource model)
        {
            modelToBeUpdated.TableNumber = model.TableNumber;
            modelToBeUpdated.NumberOfSeats = model.NumberOfSeats;
            modelToBeUpdated.Image = model.Image;
            await _table.CommitAsync();
        }
    }
}

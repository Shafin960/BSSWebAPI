using Core.Models;
using Core;
using Core.Services;
using Core.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IUnitOfWork<Employee> _employee;
        private readonly UserManager<ApplicationUser> _userManager;

        public EmployeeService(IUnitOfWork<Employee> employee, UserManager<ApplicationUser> userManager)
        {
            _employee = employee;
            _userManager = userManager;
        }

        public async Task<Employee> Create(SaveEmployeeResource newModel)
        {
            var user = new ApplicationUser
            {
                Email = newModel.Email,
                FirstName = newModel.FirstName,
                LastName = newModel.LastName,
                PhoneNumber = newModel.PhoneNumber,
                FatherName = newModel.FatherName,
                MotherName = newModel.MotherName,
                SpouseName = newModel.SpouseName,
                DOB = newModel.DOB,
                GenderId = newModel.GenderId,
                Image = newModel.Base64,
                MiddleName = newModel.MiddleName,
                UserName = newModel.PhoneNumber,
                NID = newModel.NID,
                FullName = newModel.FirstName + " " + (!String.IsNullOrEmpty(newModel.MiddleName) ? newModel.MiddleName + " " + newModel.LastName : newModel.LastName),
               
            };
            var result = await _userManager.CreateAsync(user, "12345678");
            if(result.Succeeded)
            {
                var employee = new Employee
                {
                    Designation = newModel.Designantion,
                    UserId = user.Id,
                    JoinDate = newModel.JoinDate,
                };
                await _employee.Entity.AddAsync(employee);
                await _employee.CommitAsync();
                return employee;
            }
            throw new Exception(result.Errors.First().Description);
        }

        public async Task<Employee> SingleOrDefaultAsync(Guid id) => await _employee.Entity.SingleOrDefaultAsync(id);

        public async Task<EmployeeResource> SingleOrDefaultAndSelectAsync(Guid id) => await _employee.Entity.SingleOrDefaultAndSelectAsync(
            it => new EmployeeResource
            {
                Designation=it.Designation,
            },
            it => it.Id == id
            );

        public async Task Delete(Employee model)
        {
            _employee.Entity.Remove(model);
            await _employee.CommitAsync(); 
        }

        public async Task<IEnumerable<EmployeeOptionsResource>> Get()
        {
            return await _employee.Entity.GetAndSelectAsync(it => new EmployeeOptionsResource
            {
                EmployeeId = it.Id,

            });
        }

        public async Task Update(Employee modelToBeUpdated, UpdateEmployeeResource model)
        {
            modelToBeUpdated.Designation = model.Designation;
            await _employee.CommitAsync();
        }

        public Task<IEnumerable<Food>> CreateRange(IEnumerable<Food> newModels)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GetEmployeeVM>> GetAll()
        {
            
            return await _employee.Entity.GetAndSelectAsync(it => new GetEmployeeVM
            {
                Id = it.Id,
                Designation = it.Designation,
                JoinDate = it.JoinDate.ToString("D"),
                AmountSold=it.AmountSold,
                FullName = it.User.FullName,
                Email=it.User.Email,
                Phone=it.User.PhoneNumber,
                Image=it.User.Image,

            });
        }
    }
}

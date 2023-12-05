using Core.Services;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace BSSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("get")]
        public Task<IEnumerable<EmployeeOptionsResource>> Get() => _employeeService.Get();

        [HttpGet("non-assigned-employees/{tableId}")]
        public Task<IEnumerable<EmployeeOptionsResource>> Get(int tableId) => _employeeService.Get();

        [HttpGet("datatable")]
        public Task<IEnumerable<GetEmployeeVM>> GetAll() => _employeeService.GetAll();

        [HttpPost("create")]
        public async Task Create(SaveEmployeeResource newModel)
        {
            if (!ModelState.IsValid)
            {
                return;
            }
             await _employeeService.Create(newModel);
        }

        [HttpPut("update/{id}")]
        public async Task UdpateDesignation(Guid id, [FromBody] UpdateEmployeeResource updatedModel)
        {
            var currentEmployee = await _employeeService.SingleOrDefaultAsync(id) ?? throw new Exception("Employee not found");
            await _employeeService.Update(currentEmployee, updatedModel);
        }

        [HttpDelete("delete/{id}")]
        public async Task Delete(Guid id)
        {
            var employeeToDelete = await _employeeService.SingleOrDefaultAsync(id) ?? throw new Exception("Food not found");
            await _employeeService.Delete(employeeToDelete);
        }

    }
}

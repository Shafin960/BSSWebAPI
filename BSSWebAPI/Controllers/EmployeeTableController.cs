using Core.Services;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace BSSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTableController : ControllerBase
    {
        private readonly IEmployeeTableService _employeeTableService;
        public EmployeeTableController(IEmployeeTableService employeeTableService)
        {
            _employeeTableService = employeeTableService;
        }

        [HttpGet("get")]
        public Task<IEnumerable<EmployeeTableOptionsResource>> Get() => _employeeTableService.Get();

        

        [HttpPut("update/{id}")]
        public async Task Udpate(int  id, [FromBody] SaveEmployeeTableResource updatedModel)
        {
            var currentEmployee = await _employeeTableService.SingleOrDefaultAsync(id) ?? throw new Exception("Employee not found");
            await _employeeTableService.Update(currentEmployee, updatedModel);
        }
        [HttpPost("create-range")]
        public async Task CreateMultiple(List<SaveEmployeeTableResource> newModel)
        {
            await _employeeTableService.CreateMultiple(newModel);
        }
        [HttpPost("create")]
        public async Task Create(SaveEmployeeTableResource newModel)
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            await _employeeTableService.Create(newModel);
        }
        [HttpDelete("delete")]
        public async Task Delete(int id)
        {
            var employeeToDelete = await _employeeTableService.SingleOrDefaultAsync(id) ?? throw new Exception("Food not found");
            await _employeeTableService.Delete(employeeToDelete);
        }
    }
}

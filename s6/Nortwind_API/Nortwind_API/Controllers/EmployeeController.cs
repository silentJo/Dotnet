using Microsoft.AspNetCore.Mvc;
using Nortwind_API.DTO;
using Nortwind_API.Entities;
using Nortwind_API.Repository;

namespace Nortwind_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private EmployeeRepository _employeeRepository = new EmployeeRepository();

        [HttpGet("employees")]
        public async Task<IList<EmployeeDTO>> GetAllEmployees()
        {
            var employees = await _employeeRepository.GetAllAsync();
            var employeesDTO = employees.Select(employee => new EmployeeDTO
            {
                EmployeeId = employee.EmployeeId,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
            }).ToList();
            return employeesDTO;
        }

        [HttpPost("employee")]
        public async Task<IActionResult> addEmployee([FromBody]EmployeeDTO employeeDTO)
        {
            Employee employee = new Employee { 
                EmployeeId = employeeDTO.EmployeeId,
                FirstName = employeeDTO.FirstName, 
                LastName = employeeDTO.LastName 
            };
            await _employeeRepository.InsertAsync(employee);
            return Ok("Success");
        }


    }
}
using Microsoft.AspNetCore.Mvc;
using Rest_Assignments.Entity;
using Rest_Assignments.Service;
using System.Collections.Generic;
using static Rest_Assignments.Service.EmployeeService;

namespace Rest_Assignments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeCotroller : ControllerBase
    {
        IEmployeeService _employeeService { get; set; }

        public EmployeeCotroller(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("All")]
        public IActionResult PrintAllEmployee()
        {
            return Ok(_employeeService.GetAllEmployee());
        }

        [HttpGet("GetEmployeeById/{id}")]
        
        public IActionResult GetEmployeeById(int id)
        {
            return Ok(_employeeService.GetEmployeeByID(id));
        }

        [HttpGet("GetHighestSalaryByCity/{city}")]
        
        public IActionResult GetEmployeeById(string city)
        {
            return Ok(_employeeService.GetHighestSalaryByCity(city));
        }


        [HttpPost("AddEmployee")]
        
        public void AddEmployeeWithoutId(Employee employee)
        {
            _employeeService.AddEmployee(employee);
        }

    }
}
 
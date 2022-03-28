using Benzeen.Practice.Infrastructure.Contracts.Service;
using Benzeen.Practice.Infrastructure.DTOs.Employee;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Benzeen.Practice.API.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [HttpGet("multiresult")]
        public ActionResult<EmployeeRequest> GetAllWithCount()
        {
            var employeeResponse = _employeeService.GetAllWithCount();

            return Ok(employeeResponse);
        }
        [HttpGet("Getbyid")]
        public ActionResult<EmployeeDetailsResponse> GetById(int id)
        {
            var employeeDetailsResponse = _employeeService.GetById(id);
            return Ok(employeeDetailsResponse);
        }
        [HttpGet("GetAll")]
        public ActionResult<List<EmployeeDetailsResponse>> GetAll()
        {
            var employeeDetailsResponse = _employeeService.GetAll();
            return Ok(employeeDetailsResponse);
        }
        [HttpDelete("delete")]
        public ActionResult<int> DeleteEmployee(int id)
        {
            var employee = _employeeService.DeleteEmployee(id);
            return Ok(employee);
        }
        [HttpPost("add")]
        public ActionResult<int> AddEmployee([FromBody] EmployeeRequest request)
        {
            var emoloyee = _employeeService.AddEmployee(request);
            return Ok(emoloyee);

        }
        [HttpPut("update")]
        public ActionResult<int> UpdateEmployee([FromBody] EmployeeRequest request)
        {
            
            return Ok(_employeeService.UpdateEmployee(request));
        }
    }
}

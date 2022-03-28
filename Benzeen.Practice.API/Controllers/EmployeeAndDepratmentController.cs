using Benzeen.Practice.Infrastructure.Contracts.Service;
using Benzeen.Practice.Infrastructure.DTOs.EmployeeAndDepartment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Benzeen.Practice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeAndDepratmentController : ControllerBase
    {
        private readonly IEmployeeAndDepartmentServies _services;
        public EmployeeAndDepratmentController (IEmployeeAndDepartmentServies service)
        {
            _services = service;
        }
        [HttpGet("getall")]
        public ActionResult<List<EmployeeAndDepartmentDetailResponse>> GetAll()
        {
            return Ok(_services.GetAll());

        }
    }
}

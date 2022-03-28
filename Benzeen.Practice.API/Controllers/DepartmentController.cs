using Benzeen.Practice.Infrastructure.Contracts.Service;
using Benzeen.Practice.Infrastructure.DTOs.Department;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Benzeen.Practice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpGet("GetAll")]
        public ActionResult<List<DepartmentDetailResponse>> GetAll()
        {
            return _departmentService.GetAll();
        }
        [HttpGet("multiresult")]
          public ActionResult<DepartmentResponse> GetAllWithCount()
        {
            return _departmentService.GetAllWithCount();
        }
        [HttpDelete("Delete")]
        public ActionResult<int> Delete(int id)
        {
            return Ok(_departmentService.Delete(id));
        }
        [HttpPost("AddNew")]
        public ActionResult<int> AddNew([FromBody]DepartmentRequest request)
        {
            return _departmentService.AddNew(request);
        }
        [HttpPut("Update")]
        public ActionResult<int> Update([FromBody]DepartmentRequest request)
        {
            return Ok(_departmentService.Update(request));
        }
        [HttpGet("GetById")]
        public ActionResult<DepartmentDetailResponse> GetById(int id)
        {
            return _departmentService.GetById(id);
        }
    }
}

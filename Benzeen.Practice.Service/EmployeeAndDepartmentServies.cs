using AutoMapper;
using Benzeen.Practice.Infrastructure.Contracts.DataAccess;
using Benzeen.Practice.Infrastructure.Contracts.Service;
using Benzeen.Practice.Infrastructure.DTOs.EmployeeAndDepartment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Service
{
    public class EmployeeAndDepartmentServies : IEmployeeAndDepartmentServies
    {
        private readonly IEmployeeAndDepartmentDataAccess _employeeAndDepartmentDataAccess;
        private readonly IMapper _mapper;
        public EmployeeAndDepartmentServies (IEmployeeAndDepartmentDataAccess dataAccess ,IMapper mapper )
        {
            _employeeAndDepartmentDataAccess = dataAccess;
            _mapper = mapper;
        }
        public List<EmployeeAndDepartmentDetailResponse> GetAll()
        {
            var entity = _employeeAndDepartmentDataAccess.GetAll();
            return _mapper.Map<List<EmployeeAndDepartmentDetailResponse>>(entity);
        }
    }
}

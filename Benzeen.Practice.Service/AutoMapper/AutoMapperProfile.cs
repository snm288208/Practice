using AutoMapper;
using Benzeen.Practice.Data.Entities.Department;
using Benzeen.Practice.Data.Entities.DepartmentAndEmployee;
using Benzeen.Practice.Data.Entities.Employee;
using Benzeen.Practice.Infrastructure.DTOs.Department;
using Benzeen.Practice.Infrastructure.DTOs.Employee;
using Benzeen.Practice.Infrastructure.DTOs.EmployeeAndDepartment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Service.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<EmployeeEntity, EmployeeResponse>();
            CreateMap<EmployeeDetailsEntity, EmployeeDetailsResponse>();
            CreateMap<DepartmentDetailEntity, DepartmentDetailResponse>();
            CreateMap<DepartmentEntity, DepartmentResponse>();
            CreateMap<DepartmentAndEmployeeEntiy, EmployeeAndDepartmentDetailResponse>();
        }
    }
}

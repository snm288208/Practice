using Benzeen.Practice.Infrastructure.DTOs.EmployeeAndDepartment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Infrastructure.Contracts.Service
{
    public interface IEmployeeAndDepartmentServies
    {
        List<EmployeeAndDepartmentDetailResponse> GetAll();
    }
}

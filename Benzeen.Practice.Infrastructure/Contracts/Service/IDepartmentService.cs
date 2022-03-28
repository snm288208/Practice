using Benzeen.Practice.Infrastructure.DTOs.Department;
using Benzeen.Practice.Infrastructure.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Infrastructure.Contracts.Service
{
    public interface IDepartmentService
    {
        List<DepartmentDetailResponse> GetAll();
        DepartmentResponse GetAllWithCount();
        int Delete(int id);
        int AddNew(DepartmentRequest request);
        int Update(DepartmentRequest request);
        DepartmentDetailResponse GetById(int id);
    }
}

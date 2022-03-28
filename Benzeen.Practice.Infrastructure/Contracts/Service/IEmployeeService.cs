using Benzeen.Practice.Infrastructure.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Infrastructure.Contracts.Service
{
    public interface IEmployeeService
    {
        EmployeeResponse GetAllWithCount();
        EmployeeDetailsResponse GetById(int id);
        List<EmployeeDetailsResponse> GetAll();
        int DeleteEmployee(int id);
        int AddEmployee(EmployeeRequest request);
        int UpdateEmployee(EmployeeRequest request);
    }
}

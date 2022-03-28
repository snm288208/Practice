using Benzeen.Practice.Data.Entities.Employee;
using Benzeen.Practice.Infrastructure.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Infrastructure.Contracts.DataAccess
{
    public interface IEmployeeDataAccess
    {
        EmployeeEntity GetAllWithCount();
        EmployeeDetailsEntity GetById(int id);
        List<EmployeeDetailsEntity> GetAll();
        int DeleteEmployee(int id);
        int AddEmployee(EmployeeRequest request);
        int UpdateEmployee(EmployeeRequest request);
    }
}

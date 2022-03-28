using Benzeen.Practice.Data.Entities.DepartmentAndEmployee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Infrastructure.Contracts.DataAccess
{
    public interface IEmployeeAndDepartmentDataAccess
    {
        List<DepartmentAndEmployeeEntiy> GetAll();
    }
}

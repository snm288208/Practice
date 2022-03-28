using Benzeen.Practice.Data.Entities.Department;
using Benzeen.Practice.Infrastructure.DTOs.Department;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Infrastructure.Contracts.DataAccess
{
    public interface IDepartmentDataAccess
    {
        List<DepartmentDetailEntity> GetAll();
        DepartmentEntity GetAllWithCount();
        int Delete(int id);
        int AddNew(DepartmentRequest request);
        int Update(DepartmentRequest request);
        DepartmentDetailEntity GetById(int id);
    }
}

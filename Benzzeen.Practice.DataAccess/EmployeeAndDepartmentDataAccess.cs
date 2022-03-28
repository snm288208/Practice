using Benzeen.Practice.Data.Entities.DepartmentAndEmployee;
using Benzeen.Practice.Infrastructure.Common;
using Benzeen.Practice.Infrastructure.Contracts.DataAccess;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Benzzeen.Practice.DataAccess
{
    public class EmployeeAndDepartmentDataAccess : BaseDataAccess , IEmployeeAndDepartmentDataAccess
    {
        public EmployeeAndDepartmentDataAccess(IConfiguration Config) : base(Config)
        {
        }

        public List<DepartmentAndEmployeeEntiy> GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                return connection.Query<DepartmentAndEmployeeEntiy>(Constants.StoredProcedureName.Join, commandType: CommandType.StoredProcedure).ToList();

            }
        }

    }
}

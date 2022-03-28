using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Benzeen.Practice.Data.Entities.Department;
using Dapper;
using Benzeen.Practice.Infrastructure.Common;
using System.Linq;
using Benzeen.Practice.Infrastructure.Contracts.DataAccess;
using Benzeen.Practice.Infrastructure.DTOs.Department;
using Microsoft.Extensions.Configuration;

namespace Benzzeen.Practice.DataAccess
{
    public class DepartmentDataAccess : BaseDataAccess, IDepartmentDataAccess
    {
        public DepartmentDataAccess(IConfiguration Config) : base(Config)
        {
        }

        public List<DepartmentDetailEntity> GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var EmployeesList = connection.Query<DepartmentDetailEntity>(Constants.StoredProceduresDepartment.GetAll, commandType: CommandType.StoredProcedure).ToList();
                return EmployeesList;
            }
        }
        public DepartmentEntity GetAllWithCount()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var result = connection.QueryMultiple(Constants.StoredProceduresDepartment.GetAllWithCount, commandType: CommandType.StoredProcedure);
                var departmentEntity = new DepartmentEntity();
                departmentEntity.DepartmentList = result.Read<DepartmentDetailEntity>().ToList();
                departmentEntity.Count = result.Read<int>().FirstOrDefault();
                return departmentEntity;
            }
        }
        public int Delete(int id)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add(Constants.SqlParametersDepartment.Id, id);
                var rowsAffected = connection.Execute(Constants.StoredProceduresDepartment.Delete, parameter, commandType: CommandType.StoredProcedure);
                return rowsAffected;
            }
        }
        public int AddNew(DepartmentRequest request)
        {

            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add(Constants.SqlParametersDepartment.Name, request.Department_Name);
                parameter.Add(Constants.SqlParametersDepartment.Head, request.Department_Head);
                parameter.Add(Constants.SqlParametersDepartment.Employee, request.No_OF_Employee);
                var rowsAffected = connection.Execute(Constants.StoredProceduresDepartment.AddDepartment, parameter, commandType: CommandType.StoredProcedure);
                return rowsAffected;
            }
        }
        public int Update(DepartmentRequest request)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add(Constants.SqlParametersDepartment.Id, request.Department_Id);
                parameter.Add(Constants.SqlParametersDepartment.Head, request.Department_Head);
                parameter.Add(Constants.SqlParametersDepartment.Name, request.Department_Name);
                parameter.Add(Constants.SqlParametersDepartment.Employee, request.No_OF_Employee);
                var rowseffected = connection.Execute(Constants.StoredProceduresDepartment.Update, parameter, commandType: CommandType.StoredProcedure);
                return rowseffected;
            }

        }
        public DepartmentDetailEntity GetById(int id)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parmeters = new DynamicParameters();
                parmeters.Add(Constants.SqlParametersDepartment.Id, id);
                return connection.Query<DepartmentDetailEntity>(Constants.StoredProceduresDepartment.GetById, parmeters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                
            }


        }
    }
}

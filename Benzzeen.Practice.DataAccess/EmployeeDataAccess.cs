
using Benzeen.Practice.Data.Entities.Employee;
using Benzeen.Practice.Infrastructure.Common;
using Benzeen.Practice.Infrastructure.Contracts.DataAccess;
using Benzeen.Practice.Infrastructure.DTOs.Employee;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Benzzeen.Practice.DataAccess
{
    public class EmployeeDataAccess : BaseDataAccess, IEmployeeDataAccess
    {
        public EmployeeDataAccess(IConfiguration Config) : base(Config)
        {
        }

        public EmployeeEntity GetAllWithCount()
        {

            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var employeeEntity = new EmployeeEntity();

                var result = connection.QueryMultiple(Constants.StoredProcedureName.TwoResult, commandType: CommandType.StoredProcedure);

                employeeEntity.Employees = result.Read<EmployeeDetailsEntity>().ToList();
                employeeEntity.Count = result.Read<int>().FirstOrDefault();


                return employeeEntity;
            }

        }

        public EmployeeDetailsEntity GetById(int id)
        {

            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add(Constants.SQLParameterName.Id, id);
                var employeedetailsEntity = connection.Query<EmployeeDetailsEntity>(Constants.StoredProcedureName.Getbyid, parameters , commandType: CommandType.StoredProcedure).FirstOrDefault();

                return employeedetailsEntity ;
            }

        }
        public List<EmployeeDetailsEntity> GetAll()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var employeeDetailsEntity = connection.Query<EmployeeDetailsEntity>(Constants.StoredProcedureName.GetAll , commandType:CommandType.StoredProcedure).ToList() ;
                return employeeDetailsEntity;
            }
        }
        public int DeleteEmployee(int id)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add(Constants.SQLParameterName.Id, id);
                var rowsaffected = connection.Execute(Constants.StoredProcedureName.Delete,parameters, commandType: CommandType.StoredProcedure);
                return rowsaffected;
            }
        }
        public int AddEmployee(EmployeeRequest request)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add(Constants.SQLParameterName.Name, request.Name);
                parameters.Add(Constants.SQLParameterName.Depratment, request.Department);
                parameters.Add(Constants.SQLParameterName.City , request.city);
                parameters.Add(Constants.SQLParameterName.Gender, request.Gender);
                var rowsAffected = connection.Execute(Constants.StoredProcedureName.create, parameters, commandType: CommandType.StoredProcedure);
                return rowsAffected;
            }
        }
        public int UpdateEmployee(EmployeeRequest request)
        {
            using(IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add(Constants.SQLParameterName.Id , request.EmployeeId);
                parameters.Add(Constants.SQLParameterName.Name , request.Name);
                parameters.Add(Constants.SQLParameterName.Gender , request.Gender);
                parameters.Add(Constants.SQLParameterName.Depratment , request.Department);
                parameters.Add(Constants.SQLParameterName.City, request.Gender);
                var rowsaffected = connection. Execute(Constants.StoredProcedureName.Update,parameters , commandType:CommandType.StoredProcedure);
                return rowsaffected;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Infrastructure.Common
{
    public class Constants
    {
        public class StoredProcedureName
        {
            public const string TwoResult = "TwoResult";
            public const string Getbyid = "getbyid";
            public const string GetAll = "getallemployee";
            public const string Delete = "deleteemp";
            public const string Update = "updateemp";
            public const string create = "addemployee";
            public const string Join = "GetEmployeeAndDepartment";

        }

        public class SQLParameterName
        {
            public const string Id = "@Id";
            public const string Name = "@Name";
            public const string Gender = "@gender";
            public const string Depratment = "@department";
            public const string City = "@city";
        }
        public class StoredProceduresDepartment
        {
            public const string AddDepartment = "AddDepartment";

            public const string GetAll = "GetAllDepartment";

            public const string GetById = "GetDepartmentById";

            public const string Update = "UpdateDepartment";
            public const string GetAllWithCount = "MultiResult";
            public const string Delete = "DeleteDepartment";
        }
        public class SqlParametersDepartment
        {

            public const string Id = "@id";
            public const string Name = "@name";
            public const string Employee = "@employee";
            public const string Head = "@head";
        }
    }
}

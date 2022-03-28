using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Data.Entities.Employee
{
    public class EmployeeEntity
    {
        public List<EmployeeDetailsEntity> Employees { get; set; }
        public int Count { get; set; }
    }

    public class EmployeeDetailsEntity
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string city { get; set; }
    }
}

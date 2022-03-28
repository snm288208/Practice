using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Infrastructure.DTOs.Employee
{
    public class EmployeeResponse
    {
        public List<EmployeeDetailsResponse> Employees { get; set; }
        public int Count { get; set; }
    }

    public class EmployeeDetailsResponse
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public String Department { get; set; }
        public string city { get; set; }
    }
}

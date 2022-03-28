using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Infrastructure.DTOs.Employee
{
    public class EmployeeRequest
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public String Department { get; set; }
        public string city { get; set; }
    }
}

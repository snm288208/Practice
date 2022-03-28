using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Infrastructure.DTOs.Department
{
    public class DepartmentRequest
    {
        public int Department_Id { get; set; }
        public string Department_Name { get; set; }
        public string Department_Head { get; set; }
        public int No_OF_Employee { get; set; }
    }
}

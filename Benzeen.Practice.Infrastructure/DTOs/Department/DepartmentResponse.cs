using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Infrastructure.DTOs.Department
{
    public class DepartmentResponse
    {
        public List<DepartmentDetailResponse> DepartmentList { get; set; }
        public int Count { get; set; }
    }
    public class DepartmentDetailResponse
    {
        public int Department_Id { get; set; }
        public string Department_Name { get; set; }
        public string Department_Head { get; set; }
        public int No_OF_Employee { get; set; }
    }
}

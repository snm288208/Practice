using System;
using System.Collections.Generic;
using System.Text;

namespace Benzeen.Practice.Data.Entities.Department
{
    public class DepartmentEntity
    {
        public List<DepartmentDetailEntity> DepartmentList { get; set; }
        public int Count { get; set; }
    }
     public class DepartmentDetailEntity
    {
        public int Department_Id { get; set; }
        public string Department_Name { get; set; }
        public string Department_Head { get; set; }
        public int No_OF_Employee { get; set; }
    }
}

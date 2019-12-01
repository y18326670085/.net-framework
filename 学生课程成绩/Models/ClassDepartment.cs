using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 学生课程成绩.Models
{
    public class ClassDepartment
    {
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}

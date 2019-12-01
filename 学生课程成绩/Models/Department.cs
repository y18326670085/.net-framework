using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 学生课程成绩.Models
{
    public class Department
    {
        public int Id { get; set; }
        /// <summary>
        /// 专业名,系名
        /// </summary>
        public string Name { get; set; }

        public ICollection<Student> students { get; set; }
        public ICollection<ClassDepartment> classDepartments { get; set; }
    }
}

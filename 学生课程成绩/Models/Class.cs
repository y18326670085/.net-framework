using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 学生课程成绩.Models
{
    public class Class
    {
        public int Id { get; set; }
        /// <summary>
        /// 课程名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 课程类别:1 专业课 ; 0 非专业课  
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 年级
        /// </summary>
        public string Grade { get; set; }
        

        public ICollection<GainPoint> gainPoints {get;set; }
        public ICollection<ClassDepartment> classDepartments { get; set; }
        public ICollection<StudentClass> studentClasses { get; set; }
    }
}

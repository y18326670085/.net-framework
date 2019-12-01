using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 学生课程成绩.Models
{
    public class StudentClass
    {
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 学生课程成绩.Models
{
    public class Student
    {

        public int Id { get; set; }
        /// <summary>
        /// 学号
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public string Birthday { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string RelName { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 职位
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 籍贯
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// 年级
        /// </summary>
        public string Grade{ get; set; }

        public ICollection<GainPoint> gainPoints { get; set; }
        public ICollection<StudentClass> studentClasses { get; set; }


        public int? departmentId { get; set; }
        public Department department { get; set; }


    }
}

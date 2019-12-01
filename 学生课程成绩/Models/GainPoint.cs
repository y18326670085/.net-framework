using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 学生课程成绩.Models
{
    public class GainPoint
    {

        public int Id { get; set; }

        /// <summary>
        /// 0:寒假 1:暑假
        /// </summary>
        public int Season { get; set; }
        /// <summary>
        /// 0：期中考试，1：期末考试
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 取得分数
        /// </summary>
        public int Point { get; set; }

        public Class Class { get; set; }

        public Student Student { get; set; }

    }
}

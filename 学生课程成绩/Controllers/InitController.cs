using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using 学生课程成绩.Models;

namespace 学生课程成绩.Controllers
{
    public class InitController : Controller
    {
        protected readonly LocalContext _context;
        public InitController(LocalContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Random random = new Random();

            try
            {

                var dp = new Department();
                dp.Name = "计算机";
                _context.Add(dp);

                var dp2 = new Department();
                dp2.Name = "英语";
                _context.Add(dp2);

                #region 初始化课程数据


                var 计算机导论 = new Class();
                计算机导论.Grade = "大一";
                计算机导论.Name = "计算机导论";
                计算机导论.Type = 1;
                _context.Add(计算机导论);


                var Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 计算机导论;
                _context.Add(Cs);


                var 自动控制原理 = new Class();
                自动控制原理.Grade = "大一";
                自动控制原理.Name = "自动控制原理";
                自动控制原理.Type = 1;
                _context.Add(自动控制原理);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 自动控制原理;
                _context.Add(Cs);


                var 电路 = new Class();
                电路.Grade = "大一";
                电路.Name = "电路";
                电路.Type = 1;
                _context.Add(电路);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 电路;
                _context.Add(Cs);


                var 马列主义与毛泽东思想 = new Class();
                马列主义与毛泽东思想.Grade = "大一";
                马列主义与毛泽东思想.Name = "马列主义与毛泽东思想";
                马列主义与毛泽东思想.Type = 0;
                _context.Add(马列主义与毛泽东思想);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 马列主义与毛泽东思想;
                _context.Add(Cs);


                var 大学英语一 = new Class();
                大学英语一.Grade = "大一";
                大学英语一.Name = "大学英语(一)";
                大学英语一.Type = 0;
                _context.Add(大学英语一);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 大学英语一;
                _context.Add(Cs);

                var 思想道德修养 = new Class();
                思想道德修养.Grade = "大一";
                思想道德修养.Name = "思想道德修养";
                思想道德修养.Type = 0;
                _context.Add(思想道德修养);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 思想道德修养;
                _context.Add(Cs);


                var 大学体育 = new Class();
                大学体育.Grade = "大一";
                大学体育.Name = "大学体育";
                大学体育.Type = 0;
                _context.Add(大学体育);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 大学体育;
                _context.Add(Cs);


                var 大学物理 = new Class();
                大学物理.Grade = "大一";
                大学物理.Name = "大学物理";
                大学物理.Type = 0;
                _context.Add(大学物理);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 大学物理;
                _context.Add(Cs);



                var 大学语文 = new Class();
                大学语文.Grade = "大一";
                大学语文.Name = "大学语文";
                大学语文.Type = 0;
                _context.Add(大学语文);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 大学语文;
                _context.Add(Cs);

                var 高等数学一 = new Class();
                高等数学一.Grade = "大一";
                高等数学一.Name = "高等数学(一)";
                高等数学一.Type = 0;
                _context.Add(高等数学一);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 高等数学一;
                _context.Add(Cs);


                var 线性代数 = new Class();
                线性代数.Grade = "大一";
                线性代数.Name = "线性代数";
                线性代数.Type = 0;
                _context.Add(线性代数);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 线性代数;
                _context.Add(Cs);

                var 模拟电子技术 = new Class();
                模拟电子技术.Grade = "大二";
                模拟电子技术.Name = "模拟电子技术";
                模拟电子技术.Type = 1;
                _context.Add(模拟电子技术);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 模拟电子技术;
                _context.Add(Cs);

                var 数字电子技术 = new Class();
                数字电子技术.Grade = "大二";
                数字电子技术.Name = "数字电子技术";
                数字电子技术.Type = 1;
                _context.Add(数字电子技术);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 数字电子技术;
                _context.Add(Cs);


                var C语言 = new Class();
                C语言.Grade = "大二";
                C语言.Name = "C语言";
                C语言.Type = 1;
                _context.Add(C语言);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = C语言;
                _context.Add(Cs);


                var 微机原理与接口技术 = new Class();
                微机原理与接口技术.Grade = "大二";
                微机原理与接口技术.Name = "微机原理与接口技术";
                微机原理与接口技术.Type = 1;
                _context.Add(微机原理与接口技术);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 微机原理与接口技术;
                _context.Add(Cs);

                var 离散数学 = new Class();
                离散数学.Grade = "大二";
                离散数学.Name = "离散数学";
                离散数学.Type = 1;
                _context.Add(离散数学);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 离散数学;
                _context.Add(Cs);


                var 数据结构与算法 = new Class();
                数据结构与算法.Grade = "大三";
                数据结构与算法.Name = "数据结构与算法";
                数据结构与算法.Type = 1;
                _context.Add(数据结构与算法);

                Cs = new ClassDepartment();
                Cs.Department = dp;
                Cs.Class = 数据结构与算法;
                _context.Add(Cs);

                #endregion




                //生成初始化用户数据
                var st1 = new Student();
                st1.Age = 18;
                st1.Birthday = "950101";
                st1.From = "北京";
                st1.Grade = "大一";
                st1.UserName = "zsf";
                st1.No = "180001";
                st1.RelName = "张三丰";
                st1.Password = "123";
                st1.Position = "学生";
                st1.Sex = "男";
                st1.department = dp;
                _context.Add(st1);

                #region 课程及成绩

                #region 计算机导论
                var SC = new StudentClass();
                SC.Class = 计算机导论;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                var gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion

                #endregion

                #region 自动控制原理
                SC = new StudentClass();
                SC.Class = 自动控制原理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 电路
                SC = new StudentClass();
                SC.Class = 电路;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 马列主义与毛泽东思想
                SC = new StudentClass();
                SC.Class = 马列主义与毛泽东思想;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学英语一
                SC = new StudentClass();
                SC.Class = 大学英语一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 思想道德修养
                SC = new StudentClass();
                SC.Class = 思想道德修养;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学体育
                SC = new StudentClass();
                SC.Class = 大学体育;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学物理
                SC = new StudentClass();
                SC.Class = 大学物理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学语文
                SC = new StudentClass();
                SC.Class = 大学语文;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 高等数学一
                SC = new StudentClass();
                SC.Class = 高等数学一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 线性代数
                SC = new StudentClass();
                SC.Class = 线性代数;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #endregion


                st1 = new Student();
                st1.Age = 18;
                st1.Birthday = "950301";
                st1.From = "上海";
                st1.Grade = "大一";
                st1.UserName = "zzr";
                st1.No = "180002";
                st1.RelName = "周芷若";
                st1.Password = "123";
                st1.Position = "学生";
                st1.Sex = "女";
                st1.department = dp;
                _context.Add(st1);

                #region 课程及成绩

                #region 计算机导论
                SC = new StudentClass();
                SC.Class = 计算机导论;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion

                #endregion

                #region 自动控制原理
                SC = new StudentClass();
                SC.Class = 自动控制原理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 电路
                SC = new StudentClass();
                SC.Class = 电路;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 马列主义与毛泽东思想
                SC = new StudentClass();
                SC.Class = 马列主义与毛泽东思想;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学英语一
                SC = new StudentClass();
                SC.Class = 大学英语一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 思想道德修养
                SC = new StudentClass();
                SC.Class = 思想道德修养;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学体育
                SC = new StudentClass();
                SC.Class = 大学体育;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学物理
                SC = new StudentClass();
                SC.Class = 大学物理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学语文
                SC = new StudentClass();
                SC.Class = 大学语文;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 高等数学一
                SC = new StudentClass();
                SC.Class = 高等数学一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 线性代数
                SC = new StudentClass();
                SC.Class = 线性代数;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #endregion

                st1 = new Student();
                st1.Age = 18;
                st1.Birthday = "950705";
                st1.From = "上海";
                st1.Grade = "大一";
                st1.UserName = "wtb";
                st1.No = "180003";
                st1.RelName = "王天宝";
                st1.Password = "123";
                st1.Position = "学生";
                st1.Sex = "男";
                st1.department = dp;
                _context.Add(st1);

                #region 课程及成绩

                #region 计算机导论
                SC = new StudentClass();
                SC.Class = 计算机导论;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion

                #endregion

                #region 自动控制原理
                SC = new StudentClass();
                SC.Class = 自动控制原理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 电路
                SC = new StudentClass();
                SC.Class = 电路;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 马列主义与毛泽东思想
                SC = new StudentClass();
                SC.Class = 马列主义与毛泽东思想;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学英语一
                SC = new StudentClass();
                SC.Class = 大学英语一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 思想道德修养
                SC = new StudentClass();
                SC.Class = 思想道德修养;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学体育
                SC = new StudentClass();
                SC.Class = 大学体育;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学物理
                SC = new StudentClass();
                SC.Class = 大学物理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学语文
                SC = new StudentClass();
                SC.Class = 大学语文;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 高等数学一
                SC = new StudentClass();
                SC.Class = 高等数学一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 线性代数
                SC = new StudentClass();
                SC.Class = 线性代数;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #endregion


                st1 = new Student();
                st1.Age = 18;
                st1.Birthday = "950109";
                st1.From = "河南";
                st1.Grade = "大一";
                st1.UserName = "zwj";
                st1.No = "180004";
                st1.RelName = "张无忌";
                st1.Password = "123";
                st1.Position = "学生";
                st1.Sex = "男";
                st1.department = dp;
                _context.Add(st1);

                #region 课程及成绩

                #region 计算机导论
                SC = new StudentClass();
                SC.Class = 计算机导论;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion

                #endregion

                #region 自动控制原理
                SC = new StudentClass();
                SC.Class = 自动控制原理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 电路
                SC = new StudentClass();
                SC.Class = 电路;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 马列主义与毛泽东思想
                SC = new StudentClass();
                SC.Class = 马列主义与毛泽东思想;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学英语一
                SC = new StudentClass();
                SC.Class = 大学英语一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 思想道德修养
                SC = new StudentClass();
                SC.Class = 思想道德修养;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学体育
                SC = new StudentClass();
                SC.Class = 大学体育;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学物理
                SC = new StudentClass();
                SC.Class = 大学物理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学语文
                SC = new StudentClass();
                SC.Class = 大学语文;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 高等数学一
                SC = new StudentClass();
                SC.Class = 高等数学一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 线性代数
                SC = new StudentClass();
                SC.Class = 线性代数;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #endregion



                st1 = new Student();
                st1.Age = 18;
                st1.Birthday = "950629";
                st1.From = "重庆";
                st1.Grade = "";
                st1.UserName = "mjst";
                st1.No = "";
                st1.RelName = "灭绝师太";
                st1.Password = "123";
                st1.Position = "教师";
                st1.Sex = "女";
                st1.department = dp;
                _context.Add(st1);





                st1 = new Student();
                st1.Age = 18;
                st1.Birthday = "950809";
                st1.From = "香港";
                st1.Grade = "大一";
                st1.UserName = "zm";
                st1.No = "180005";
                st1.RelName = "赵敏";
                st1.Password = "123";
                st1.Position = "班长";
                st1.Sex = "女";
                st1.department = dp;
                _context.Add(st1);

                #region 课程及成绩

                #region 计算机导论
                SC = new StudentClass();
                SC.Class = 计算机导论;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion

                #endregion

                #region 自动控制原理
                SC = new StudentClass();
                SC.Class = 自动控制原理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 电路
                SC = new StudentClass();
                SC.Class = 电路;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 马列主义与毛泽东思想
                SC = new StudentClass();
                SC.Class = 马列主义与毛泽东思想;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学英语一
                SC = new StudentClass();
                SC.Class = 大学英语一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 思想道德修养
                SC = new StudentClass();
                SC.Class = 思想道德修养;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学体育
                SC = new StudentClass();
                SC.Class = 大学体育;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学物理
                SC = new StudentClass();
                SC.Class = 大学物理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学语文
                SC = new StudentClass();
                SC.Class = 大学语文;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 高等数学一
                SC = new StudentClass();
                SC.Class = 高等数学一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 线性代数
                SC = new StudentClass();
                SC.Class = 线性代数;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #endregion


                st1 = new Student();
                st1.Age = 19;
                st1.Birthday = "940205";
                st1.From = "南京";
                st1.Grade = "大二";
                st1.UserName = "xx";
                st1.No = "170001";
                st1.RelName = "谢逊";
                st1.Password = "123";
                st1.Position = "班长";
                st1.Sex = "男";
                st1.department = dp;
                _context.Add(st1);

                #region 课程及成绩

                #region 模拟电子技术
                SC = new StudentClass();
                SC.Class = 模拟电子技术;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion

                #endregion

                #region 数字电子技术
                SC = new StudentClass();
                SC.Class = 数字电子技术;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region C语言
                SC = new StudentClass();
                SC.Class = C语言;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 微机原理与接口技术
                SC = new StudentClass();
                SC.Class = 微机原理与接口技术;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 离散数学
                SC = new StudentClass();
                SC.Class = 离散数学;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion



                #endregion



                st1 = new Student();
                st1.Age = 19;
                st1.Birthday = "941005";
                st1.From = "天津";
                st1.Grade = "大二";
                st1.UserName = "yx";
                st1.No = "170002";
                st1.RelName = "杨逍";
                st1.Password = "123";
                st1.Position = "学生";
                st1.Sex = "男";
                st1.department = dp;
                _context.Add(st1);

                #region 课程及成绩

                #region 模拟电子技术
                SC = new StudentClass();
                SC.Class = 模拟电子技术;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion

                #endregion

                #region 数字电子技术
                SC = new StudentClass();
                SC.Class = 数字电子技术;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region C语言
                SC = new StudentClass();
                SC.Class = C语言;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 微机原理与接口技术
                SC = new StudentClass();
                SC.Class = 微机原理与接口技术;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 离散数学
                SC = new StudentClass();
                SC.Class = 离散数学;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion



                #endregion



                st1 = new Student();
                st1.Age = 18;
                st1.Birthday = "951104";
                st1.From = "淮南";
                st1.Grade = "大一";
                st1.UserName = "yxx";
                st1.No = "180009";
                st1.RelName = "殷素素";
                st1.Password = "123";
                st1.Position = "学生";
                st1.Sex = "女";
                st1.department = dp;
                _context.Add(st1);

                #region 课程及成绩

                #region 计算机导论
                SC = new StudentClass();
                SC.Class = 计算机导论;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion

                #endregion

                #region 自动控制原理
                SC = new StudentClass();
                SC.Class = 自动控制原理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 电路
                SC = new StudentClass();
                SC.Class = 电路;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 马列主义与毛泽东思想
                SC = new StudentClass();
                SC.Class = 马列主义与毛泽东思想;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学英语一
                SC = new StudentClass();
                SC.Class = 大学英语一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 思想道德修养
                SC = new StudentClass();
                SC.Class = 思想道德修养;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学体育
                SC = new StudentClass();
                SC.Class = 大学体育;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学物理
                SC = new StudentClass();
                SC.Class = 大学物理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学语文
                SC = new StudentClass();
                SC.Class = 大学语文;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 高等数学一
                SC = new StudentClass();
                SC.Class = 高等数学一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 线性代数
                SC = new StudentClass();
                SC.Class = 线性代数;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #endregion



                st1 = new Student();
                st1.Age = 19;
                st1.Birthday = "951104";
                st1.From = "大理";
                st1.Grade = "大二";
                st1.UserName = "ck";
                st1.No = "170003";
                st1.RelName = "成昆";
                st1.Password = "123";
                st1.Position = "学生";
                st1.Sex = "男";
                st1.department = dp;
                _context.Add(st1);

                #region 课程及成绩

                #region 模拟电子技术
                SC = new StudentClass();
                SC.Class = 模拟电子技术;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion

                #endregion

                #region 数字电子技术
                SC = new StudentClass();
                SC.Class = 数字电子技术;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region C语言
                SC = new StudentClass();
                SC.Class = C语言;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 微机原理与接口技术
                SC = new StudentClass();
                SC.Class = 微机原理与接口技术;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 离散数学
                SC = new StudentClass();
                SC.Class = 离散数学;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion



                #endregion



                st1 = new Student();
                st1.Age = 20;
                st1.Birthday = "941104";
                st1.From = "丽江";
                st1.Grade = "大三";
                st1.UserName = "ytz";
                st1.No = "160001";
                st1.RelName = "殷天正";
                st1.Password = "123";
                st1.Position = "学生";
                st1.Sex = "男";
                st1.department = dp2;
                _context.Add(st1);

                #region 课程及成绩

                #region 数据结构与算法
                SC = new StudentClass();
                SC.Class = 数据结构与算法;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion
                #endregion

                st1 = new Student();
                st1.Age = 18;
                st1.Birthday = "961014";
                st1.From = "大理";
                st1.Grade = "大一";
                st1.UserName = "fy";
                st1.No = "180006";
                st1.RelName = "范遥";
                st1.Password = "123";
                st1.Position = "学生";
                st1.Sex = "男";
                st1.department = dp;
                _context.Add(st1);

                #region 课程及成绩

                #region 计算机导论
                SC = new StudentClass();
                SC.Class = 计算机导论;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion

                #endregion

                #region 自动控制原理
                SC = new StudentClass();
                SC.Class = 自动控制原理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 电路
                SC = new StudentClass();
                SC.Class = 电路;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 马列主义与毛泽东思想
                SC = new StudentClass();
                SC.Class = 马列主义与毛泽东思想;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学英语一
                SC = new StudentClass();
                SC.Class = 大学英语一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 思想道德修养
                SC = new StudentClass();
                SC.Class = 思想道德修养;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学体育
                SC = new StudentClass();
                SC.Class = 大学体育;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学物理
                SC = new StudentClass();
                SC.Class = 大学物理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学语文
                SC = new StudentClass();
                SC.Class = 大学语文;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 高等数学一
                SC = new StudentClass();
                SC.Class = 高等数学一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 线性代数
                SC = new StudentClass();
                SC.Class = 线性代数;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #endregion



                st1 = new Student();
                st1.Age = 18;
                st1.Birthday = "961221";
                st1.From = "大理";
                st1.Grade = "大一";
                st1.UserName = "xz";
                st1.No = "180007";
                st1.RelName = "小昭";
                st1.Password = "123";
                st1.Position = "班长";
                st1.Sex = "女";
                st1.department = dp;
                _context.Add(st1);

                #region 课程及成绩

                #region 计算机导论
                SC = new StudentClass();
                SC.Class = 计算机导论;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion

                #endregion

                #region 自动控制原理
                SC = new StudentClass();
                SC.Class = 自动控制原理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 电路
                SC = new StudentClass();
                SC.Class = 电路;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 马列主义与毛泽东思想
                SC = new StudentClass();
                SC.Class = 马列主义与毛泽东思想;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学英语一
                SC = new StudentClass();
                SC.Class = 大学英语一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 思想道德修养
                SC = new StudentClass();
                SC.Class = 思想道德修养;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学体育
                SC = new StudentClass();
                SC.Class = 大学体育;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学物理
                SC = new StudentClass();
                SC.Class = 大学物理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学语文
                SC = new StudentClass();
                SC.Class = 大学语文;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 高等数学一
                SC = new StudentClass();
                SC.Class = 高等数学一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 线性代数
                SC = new StudentClass();
                SC.Class = 线性代数;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #endregion



                st1 = new Student();
                st1.Age = 18;
                st1.Birthday = "960916";
                st1.From = "大理";
                st1.Grade = "大一";
                st1.UserName = "ybh";
                st1.No = "180008";
                st1.RelName = "杨不悔";
                st1.Password = "123";
                st1.Position = "学生";
                st1.Sex = "女";
                st1.department = dp;
                _context.Add(st1);

                #region 课程及成绩

                #region 计算机导论
                SC = new StudentClass();
                SC.Class = 计算机导论;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion

                #endregion

                #region 自动控制原理
                SC = new StudentClass();
                SC.Class = 自动控制原理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 电路
                SC = new StudentClass();
                SC.Class = 电路;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 马列主义与毛泽东思想
                SC = new StudentClass();
                SC.Class = 马列主义与毛泽东思想;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学英语一
                SC = new StudentClass();
                SC.Class = 大学英语一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 思想道德修养
                SC = new StudentClass();
                SC.Class = 思想道德修养;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学体育
                SC = new StudentClass();
                SC.Class = 大学体育;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学物理
                SC = new StudentClass();
                SC.Class = 大学物理;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 大学语文
                SC = new StudentClass();
                SC.Class = 大学语文;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 高等数学一
                SC = new StudentClass();
                SC.Class = 高等数学一;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #region 线性代数
                SC = new StudentClass();
                SC.Class = 线性代数;
                SC.Student = st1;
                _context.Add(SC);

                #region 成绩
                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 0;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 0;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);

                gp = new GainPoint();
                gp.Point = random.Next(40, 100);
                gp.Season = 1;
                gp.Type = 1;
                gp.Student = st1;
                gp.Class = SC.Class;
                _context.Add(gp);
                #endregion
                #endregion

                #endregion


                _context.SaveChanges();



                return Content("初始化成功");
            }
            catch (Exception e) {
                throw e;
            }
        }
    }
}
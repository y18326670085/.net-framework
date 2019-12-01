using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using 学生课程成绩.Models;

namespace 学生课程成绩.Controllers
{
    public class MainController : Controller
    {
        protected readonly LocalContext _context;
        public MainController(LocalContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "班长,学生,教师")]
        /// <summary>
        /// 登陆成后的欢迎页
        /// 获取登录人的名字和角色在view里显示个人信息
        /// 如果是班长和教师会有相应的功能显示
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {

            #region 如果不知道怎么获取，可以百度 怎么获取cookie里面的角色   也可以搜索ID

            //#####  获取当前登录的用户名 使用cookie从login过来的值
            string name = Request.HttpContext.User.Claims.FirstOrDefault(s => s.Type == ClaimTypes.Sid).Value;

            //获取当前的角色
            string role = Request.HttpContext.User.Claims.FirstOrDefault(s => s.Type == ClaimTypes.Role).Value;

            #endregion


            //### 获取当前登录用户的所有信息
            //ViewBag.Stu = _context.Student_DB.FirstOrDefault(x=>x.UserName == name);
            //### use include 当关联关系
            //ViewBag.Stu = _context.Student_DB.Include(x => x.department).ToList();

            ViewBag.Stu = _context.Student_DB.Where(x => x.UserName == name).Include(x => x.department).ToList();              
            ViewBag.Role = role;

            //获取个人全部的信息

            return View();
        }


        /// <summary>
        /// 学生管理界面
        /// 来自于查看所有学生成绩的点击
        /// string cla 并未使用
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "教师,班长")]
        public IActionResult Students(string cla)
        {
            string role = Request.HttpContext.User.Claims.FirstOrDefault(s => s.Type == ClaimTypes.Role).Value;
            ViewBag.Role = role;

            if (role == "教师")
            {
                //##### 查看所有学生的成绩
                ViewBag.stuList = _context.Student_DB.Include(x => x.department).ToList();
            }
            if (role == "班长")
            {
                //##### 这里显示和班长同年级的学生 因为没有班级这个字段 只有年级的
                //ViewBag.Stu = _context.Student_DB.Where(x => x.Grade == cla);

                //######## 从数据库里不要选择教师出来 ############
                //ViewBag.stuList = _context.Student_DB.Include(x => x.department).ToList();

                ViewBag.stuList = _context.Student_DB.Where(x=>x.Position!="教师").Include(x => x.department).ToList();



            }

            return View();
        }


        //##### 这个是点击超链接 进入的 input 页面
        public IActionResult Add()
        {
            return View();
        }

        [Authorize(Roles = "教师")]
        [HttpPost]
        public IActionResult Add(string UserName, string RelName,
                                string No, string Password, string Sex, int Age,
                                string Grade,string Birthday, string From,
                                string Position, string Department)
        {

            var st1 = new Student();
            st1.UserName = UserName;
            st1.RelName = RelName;
            st1.No = No;
            st1.Password = Password;
            st1.Sex = Sex;
            st1.Age = Age;
            st1.Grade = Grade;
            st1.Birthday = Birthday;
            st1.From = From;
            st1.Position = Position;

            var dp = new Department();
            dp.Name = Department;           
            st1.department = dp;

            
            _context.Add(st1);
            _context.SaveChanges();

            return RedirectToAction(nameof(MainController.Index), "Main");
        }

        [Authorize(Roles = "教师")]
        public IActionResult Edit(int Id)
        {
            //Student stu = _context.Student_DB.Find(Id);
            //############################################### 这里起作用了
            ViewBag.stu = _context.Student_DB.Where(x => x.Id == Id).Include(x => x.department).ToList().FirstOrDefault(x=>x.Id == Id);

            //ViewBag.Stu = stu;
            return View();
        }


        [HttpPost]
        [Authorize(Roles = "教师")]
        public IActionResult Edit(string UserName, string RelName,
                                string No, string Password, string Sex, int Age,
                                string Grade, string Birthday, string From,
                                string Position, string dptname)
        {
            //Student stu = _context.Students_DB.Find(id);
            //_context.Entry<Student>(stu).State = EntityState.Modified;
            //_context.SaveChanges();

            var stu = _context.Student_DB.FirstOrDefault(x => x.No == No);
            
            if (stu != null)
            {
                stu.RelName = RelName; stu.Sex = Sex; stu.Age = Age;
                stu.Grade = Grade; stu.Birthday = Birthday; stu.From = From;
                stu.No = No; stu.UserName = UserName; stu.Password = Password;
                stu.Position = Position;

                var temp = _context.Department_DB.FirstOrDefault(x => x.Name == dptname);
                int dId = temp.Id;
                stu.departmentId = dId;

                //stu.department.Name = department;             
            }

            _context.SaveChanges();

            return RedirectToAction(nameof(MainController.Index), "Main");
        }

        [Authorize(Roles = "教师")]
        public IActionResult Delete(int Id, int did)
        {
            //var stu = _context.Students_DB.Where(x => x.SNumber == identify);

            Student stu = _context.Student_DB.Find(Id);         
            _context.Student_DB.Remove(stu);
            _context.SaveChanges();

            //_context.Entry<Student>(stu).State = EntityState.Modified;
            //_context.SaveChanges();

            return RedirectToAction(nameof(MainController.Index), "Main");
        }


        [Authorize(Roles = "教师,班长")]
        public IActionResult Filter(string identify)
        {
            //Student stu = _context.Students_DB.Find(identify);
            var stu = _context.Student_DB.Where(x => x.No == identify).Include(x=>x.department).FirstOrDefault();
            ViewBag.stu = stu;
            ViewBag.Gp = _context.GainPoint_DB.Where(x => x.Student.Id == stu.Id).Include(x => x.Student).Include(x => x.Class).ToList();

            return View();
        }

        /// <summary>
        /// 在显示所有students信息的页面上点击单个学生
        /// 获得这个学生的id传递进来
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Roles = "教师")]
        public IActionResult Modify(int id)
        {
            
            ViewBag.Stu = _context.Student_DB.Where(x => x.Id == id).Include(x => x.department).Include(x=>x.studentClasses).Include(x=>x.gainPoints).FirstOrDefault();
            ViewBag.Gp = _context.GainPoint_DB.Where(x => x.Student.Id == id).Include(x => x.Student).Include(x=>x.Class).ToList();

            return View();
        }


        [HttpPost]
        [Authorize(Roles = "教师")]
        public IActionResult Modify(string classname, string point, string type, string grade, int sid)
        {
            int ifMajor;
            if (type == "是")
            {
                ifMajor = 1;
            }
            else
            {
                ifMajor = 0;
            }

            var clas = new Class();
            clas.Grade = grade;
            clas.Name = classname;
            clas.Type = ifMajor;
            _context.Add(clas);

            var gp = new GainPoint();
            gp.Point = Convert.ToInt32(point);
            gp.Season = 0;
            gp.Type = ifMajor;

            Student stu = _context.Student_DB.Find(sid);
            gp.Student = stu;
            
            gp.Class = clas;
            _context.Add(gp);

            _context.SaveChanges();


            //return Content("传值进来进行编辑");
            return RedirectToAction(nameof(MainController.Index), "Main");
        }


        //id 是分数对应的id
        [Authorize(Roles = "教师")]
        public IActionResult Editstudyinfo(string sname, string cname, int type, int point, int season, int id)
        {
            ViewBag.id = id;

            ViewBag.sname = sname;
            ViewBag.cname = cname;
            ViewBag.point = point;
            ViewBag.type = type;
            ViewBag.season = season;

            return View();
        }


        //关于编辑学生的选课和分数
        //学生的个人信息不在这里修改
        //这里可以改的是分数、是否选修和寒暑假
        
        [HttpPost]
        [Authorize(Roles = "教师")]
        public IActionResult Editstudyinfo(int point, int type, int season, int id)
        {
            GainPoint gp = _context.GainPoint_DB.Where(x => x.Id == id).Include(x => x.Class).Include(x => x.Student).FirstOrDefault();

            ////var classId = _context.Class_DB.Where(x => x.Name == n).FirstOrDefault().Id;
            ////var studentId = _context.Student_DB.Where(x => x.Id == sid).FirstOrDefault().Id;

            gp.Point = point;
            gp.Type = type;
            gp.Season = season;

            _context.SaveChanges();


            return RedirectToAction(nameof(MainController.Index), "Main");
            //return Content("操作成功点击箭头返回上一页");
        }


        [Authorize(Roles = "教师")]
        public IActionResult Deletestudyinfo(int id)
        {
            GainPoint gp = _context.GainPoint_DB.Where(x => x.Id == id).Include(x => x.Class).Include(x => x.Student).FirstOrDefault();
            _context.Remove(gp);
            _context.SaveChanges();

            return Content("操作成功点击箭头返回上一页");
        }


        /// <summary>
        /// 这个方法解决了学生信息的查询通过id的方式
        /// 用户名之前存在了cookie里面
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "学生,班长,教师")]
        public IActionResult StudentDetail()
        {
            //获取当前登录的用户名
            string name = Request.HttpContext.User.Claims.FirstOrDefault(s => s.Type == ClaimTypes.Sid).Value;
            //获取当前登录用户的所有信息
            //var Stu = _context.Student_DB.FirstOrDefault(x => x.UserName == name);

            var stu = _context.Student_DB.Where(x => x.UserName == name).Include(x => x.department).FirstOrDefault();
            ViewBag.stu = stu;

            var gp = _context.GainPoint_DB.Where(x => x.Student.Id == stu.Id).Include(x => x.Class).ToList();
            ViewBag.Gp = gp;

            //return Content("班长查看");
            return View();
        }


        /// <summary>
        /// 班长和教师点击单个学生显示
        /// 课程分数等相关信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize(Roles = "班长,教师")]
        public IActionResult StudentsDetail(int id)
        {

            var stu = _context.Student_DB.Where(x => x.Id == id).Include(x => x.department).FirstOrDefault();
            ViewBag.stu = stu;

            var gp = _context.GainPoint_DB.Where(x => x.Student.Id == stu.Id).Include(x => x.Class).ToList();
            ViewBag.Gp = gp;

            //return Content("班长查看");
            return View();
        }





















        /// <summary>
        /// 学生管理界面
        /// </summary>
        /// <returns></returns>
        //[Authorize(Roles = "班长")]
        //public IActionResult StudentLeader()
        //{
        //    //获取当前登录的用户名
        //    string name = Request.HttpContext.User.Claims.FirstOrDefault(s => s.Type == ClaimTypes.Sid).Value;
        //    var stu = _context.Student_DB.Include(x=>x.department).FirstOrDefault(x => x.UserName == name);

        //    //获取班长自己所在的年级的所有学生的列表（年级和专业匹配）
        //    ViewBag.List = _context.Student_DB.Where(x=>x.Grade==stu.Grade && x.departmentId == stu.departmentId).ToList();
        //    ViewBag.Stu = stu;
        //    return View();

        //}


    }
}
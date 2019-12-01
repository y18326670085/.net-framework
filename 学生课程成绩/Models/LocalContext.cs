using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 学生课程成绩.Models
{
    public class LocalContext : DbContext
    {
        //注入连接字符串
        public LocalContext(DbContextOptions<LocalContext> options) : base(options) { }

        ///绑定实体的映射关系，CodeFirst会用到。如果不会配置这里，可以不用从代码生成数据库，自己从数据库管理工具
        ///如：sql managerment studio,在图形化界面手动插入。
        /// 这里可以加载实体的相关配置，以及定义实体键的关联关系和映射。

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());

            modelBuilder.Entity<ClassDepartment>().HasKey(ud => new { ud.ClassId, ud.DepartmentId });
            modelBuilder.Entity<ClassDepartment>().HasOne(u => u.Class).WithMany(m => m.classDepartments);
            modelBuilder.Entity<ClassDepartment>().HasOne(um => um.Department).WithMany(m => m.classDepartments);
            modelBuilder.Entity<StudentClass>().HasKey(ud => new { ud.ClassId, ud.StudentId });
            modelBuilder.Entity<StudentClass>().HasOne(u => u.Class).WithMany(m => m.studentClasses);
            modelBuilder.Entity<StudentClass>().HasOne(um => um.Student).WithMany(m => m.studentClasses);


            modelBuilder.Entity<Student>().HasOne(u => u.department).WithMany(m => m.students).HasForeignKey(d=>d.departmentId);


        }



    ///绑定实体和数据库表名,为便于你理解，做些区分
    public DbSet<Student> Student_DB { get; set; }
        public DbSet<Class> Class_DB { get; set; }
        public DbSet<Department> Department_DB { get; set; }
        public DbSet<GainPoint> GainPoint_DB { get; set; }
        public DbSet<StudentClass> StudentClass { get; set; }
        public DbSet<ClassDepartment> ClassDepartment { get; set; }

    }
}

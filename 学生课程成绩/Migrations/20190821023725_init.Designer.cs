﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using 学生课程成绩.Models;

namespace 学生课程成绩.Migrations
{
    [DbContext(typeof(LocalContext))]
    [Migration("20190821023725_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("学生课程成绩.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Grade");

                    b.Property<string>("Name");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Class_DB");
                });

            modelBuilder.Entity("学生课程成绩.Models.ClassDepartment", b =>
                {
                    b.Property<int>("ClassId");

                    b.Property<int>("DepartmentId");

                    b.HasKey("ClassId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("ClassDepartment");
                });

            modelBuilder.Entity("学生课程成绩.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department_DB");
                });

            modelBuilder.Entity("学生课程成绩.Models.GainPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClassId");

                    b.Property<int>("Point");

                    b.Property<int>("Season");

                    b.Property<int?>("StudentId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("StudentId");

                    b.ToTable("GainPoint_DB");
                });

            modelBuilder.Entity("学生课程成绩.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Birthday");

                    b.Property<string>("From")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Grade");

                    b.Property<string>("No");

                    b.Property<string>("Password");

                    b.Property<string>("Position");

                    b.Property<string>("RelName");

                    b.Property<string>("Sex");

                    b.Property<string>("UserName");

                    b.Property<int?>("departmentId");

                    b.HasKey("Id");

                    b.HasIndex("departmentId");

                    b.ToTable("Student_DB");
                });

            modelBuilder.Entity("学生课程成绩.Models.StudentClass", b =>
                {
                    b.Property<int>("ClassId");

                    b.Property<int>("StudentId");

                    b.HasKey("ClassId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentClass");
                });

            modelBuilder.Entity("学生课程成绩.Models.ClassDepartment", b =>
                {
                    b.HasOne("学生课程成绩.Models.Class", "Class")
                        .WithMany("classDepartments")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("学生课程成绩.Models.Department", "Department")
                        .WithMany("classDepartments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("学生课程成绩.Models.GainPoint", b =>
                {
                    b.HasOne("学生课程成绩.Models.Class", "Class")
                        .WithMany("gainPoints")
                        .HasForeignKey("ClassId");

                    b.HasOne("学生课程成绩.Models.Student", "Student")
                        .WithMany("gainPoints")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("学生课程成绩.Models.Student", b =>
                {
                    b.HasOne("学生课程成绩.Models.Department", "department")
                        .WithMany("students")
                        .HasForeignKey("departmentId");
                });

            modelBuilder.Entity("学生课程成绩.Models.StudentClass", b =>
                {
                    b.HasOne("学生课程成绩.Models.Class", "Class")
                        .WithMany("studentClasses")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("学生课程成绩.Models.Student", "Student")
                        .WithMany("studentClasses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

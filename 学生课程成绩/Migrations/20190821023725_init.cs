using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace 学生课程成绩.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class_DB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Grade = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class_DB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department_DB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department_DB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClassDepartment",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassDepartment", x => new { x.ClassId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_ClassDepartment_Class_DB_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class_DB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassDepartment_Department_DB_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department_DB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student_DB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<int>(nullable: false),
                    Birthday = table.Column<string>(nullable: true),
                    From = table.Column<string>(type: "varchar(100)", nullable: true),
                    Grade = table.Column<string>(nullable: true),
                    No = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    RelName = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    departmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_DB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_DB_Department_DB_departmentId",
                        column: x => x.departmentId,
                        principalTable: "Department_DB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GainPoint_DB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassId = table.Column<int>(nullable: true),
                    Point = table.Column<int>(nullable: false),
                    Season = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GainPoint_DB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GainPoint_DB_Class_DB_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class_DB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GainPoint_DB_Student_DB_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student_DB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentClass",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClass", x => new { x.ClassId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_StudentClass_Class_DB_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class_DB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentClass_Student_DB_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student_DB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassDepartment_DepartmentId",
                table: "ClassDepartment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_GainPoint_DB_ClassId",
                table: "GainPoint_DB",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_GainPoint_DB_StudentId",
                table: "GainPoint_DB",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_DB_departmentId",
                table: "Student_DB",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClass_StudentId",
                table: "StudentClass",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassDepartment");

            migrationBuilder.DropTable(
                name: "GainPoint_DB");

            migrationBuilder.DropTable(
                name: "StudentClass");

            migrationBuilder.DropTable(
                name: "Class_DB");

            migrationBuilder.DropTable(
                name: "Student_DB");

            migrationBuilder.DropTable(
                name: "Department_DB");
        }
    }
}

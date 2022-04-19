using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_learningFinalProject.Data.Migrations
{
    public partial class StudentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CourseObjective = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CourseOutline = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CourseCredit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    ProfessorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessorFName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ProfessorLName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ProfessorDOB = table.Column<DateTime>(type: "date", nullable: false),
                    ProfessorPhone = table.Column<int>(type: "int", nullable: false),
                    ProfessorAdd = table.Column<string>(type: "nvarchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.ProfessorID);
                });

            migrationBuilder.CreateTable(
                name: "semesters",
                columns: table => new
                {
                    SemesterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SemesterName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SemesterYear = table.Column<int>(type: "int", nullable: false),
                    SemesterStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    SemesterEndDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_semesters", x => x.SemesterID);
                });

            migrationBuilder.CreateTable(
                name: "semesterSchedules",
                columns: table => new
                {
                    SemesterScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SemesterID = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    ProfessorID = table.Column<int>(type: "int", nullable: false),
                    MethodOfDelivery = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_semesterSchedules", x => x.SemesterScheduleID);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentFName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    StudentLName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    StudentDOB = table.Column<DateTime>(type: "date", nullable: false),
                    StudentPhone = table.Column<int>(type: "int", nullable: false),
                    StudentAdd = table.Column<string>(type: "nvarchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "studentSchedules",
                columns: table => new
                {
                    StudentScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SemesterScheduleID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    FinalGrade = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentSchedules", x => x.StudentScheduleID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "semesters");

            migrationBuilder.DropTable(
                name: "semesterSchedules");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "studentSchedules");
        }
    }
}

using E_learningFinalProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_learningFinalProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Semester> semesters { get; set; }
        public DbSet<Professor> professors { get; set; }
        public DbSet<SemesterSchedule> semesterSchedules { get; set; }
        public DbSet<StudentSchedule> studentSchedules { get; set; }





        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
                
    }





        public DbSet<E_learningFinalProject.Models.Professor> Professor { get; set; }
    }
}

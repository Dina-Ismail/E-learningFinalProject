using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_learningFinalProject.Models
{
    public class Course
    {
        [Column(Order = 0, TypeName = "int")]
        public int CourseID { get; set; }

        [Required(ErrorMessage = "Course Name cannot be blank")]
        [Column(Order = 1, TypeName = "nvarchar(50)")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Course Objective cannot be blank")]
        [Column(Order = 2, TypeName = "nvarchar(50)")]
        public string CourseObjective { get; set; }

        [Required(ErrorMessage = "Course Outline cannot be blank")]
        [Column(Order = 3, TypeName = "nvarchar(50)")]
        public string CourseOutline { get; set; }

        [Required(ErrorMessage = "Course Credit cannot be blank")]
        [Column(Order = 4, TypeName = "int")]
        public int CourseCredit { get; set; }
    }
}

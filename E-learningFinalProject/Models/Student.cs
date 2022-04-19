using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_learningFinalProject.Models
{
    public class Student
    {
        [Column(Order = 0, TypeName = "int")]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Student First Name cannot be blank")]
        [Column(Order = 1, TypeName = "nvarchar(50)")]
        [Display (Name ="First Name")]
        public string StudentFName { get; set; }

        [Required(ErrorMessage = "Student Last Name cannot be blank")]
        [Column(Order = 2, TypeName = "nvarchar(50)")]
        [Display(Name = "Last Name")]
        public string StudentLName { get; set; }

        [Required(ErrorMessage = "Date of Birth can't be blank")]
        [Column(Order = 3, TypeName = "date")]
        [Display(Name = "Date Of Birth")]
        public DateTime StudentDOB { get; set; }

        [Required(ErrorMessage = "Phone cannot be blank")]
        [Column(Order = 4, TypeName = "int")]
        [Display(Name = "Phone")]
        public int StudentPhone { get; set; }

        [Required(ErrorMessage = "Student Address cannot be blank")]
        [Column(Order = 5, TypeName = "nvarchar(150)")]
        [Display(Name = "Address")]
        public string StudentAdd { get; set; }

    }
}

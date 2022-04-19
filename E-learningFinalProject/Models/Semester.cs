using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_learningFinalProject.Models
{
    public class Semester
    {
        [Column(Order = 0, TypeName = "int")]
        public int SemesterID { get; set; }

        [Required(ErrorMessage = "Semester Name cannot be blank")]
        [Column(Order = 1, TypeName = "nvarchar(50)")]
        public string SemesterName { get; set; }

        [Required(ErrorMessage = "Semester Year cannot be blank")]
        [Column(Order = 2, TypeName = "int")]
        public int SemesterYear { get; set; }

        [Required(ErrorMessage = "Semester Start Date cannot be blank")]
        [Column(Order = 3, TypeName = "date")]
        public DateTime SemesterStartDate { get; set; }

        [Required(ErrorMessage = "Semester End Date cannot be blank")]
        [Column(Order = 4, TypeName = "date")]
        public DateTime SemesterEndDate { get; set; }
    }
}

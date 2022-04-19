using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_learningFinalProject.Models
{
    public class StudentSchedule
    {
        [Column(Order = 0, TypeName = "int")]
        public int StudentScheduleID { get; set; }

        [Column(Order = 1, TypeName = "int")]
        public int SemesterScheduleID { get; set; }

        [Column(Order = 2, TypeName = "int")]
        public int StudentID { get; set; }

        [Column(Order = 3, TypeName = "int")]
        public int FinalGrade { get; set; }

        [Column(Order = 4, TypeName = "nvarchar(100)")]
        public string Comment { get; set; }
    }
}

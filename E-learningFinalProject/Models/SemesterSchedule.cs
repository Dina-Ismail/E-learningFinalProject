using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_learningFinalProject.Models
{
    public class SemesterSchedule
    {
        [Column(Order = 0, TypeName = "int")]
        public int SemesterScheduleID { get; set; }

        [Column(Order = 1, TypeName = "int")]
        public int SemesterID { get; set; }

        [Column(Order = 2, TypeName = "int")]
        public int CourseID { get; set; }

        [Column(Order = 3, TypeName = "int")]
        public int ProfessorID { get; set; }

        [Column(Order = 4, TypeName = "nvarchar(100)")]
        public string MethodOfDelivery { get; set; }
    }
}

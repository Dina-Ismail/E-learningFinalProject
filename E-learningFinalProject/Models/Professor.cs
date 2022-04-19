using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_learningFinalProject.Models
{
    public class Professor
    {
        [Column(Order = 0, TypeName = "int")]
        public int ProfessorID { get; set; }

        [Required(ErrorMessage = "Professor First Name cannot be blank")]
        [Column(Order = 1, TypeName = "nvarchar(50)")]
        public string ProfessorFName { get; set; }

        [Required(ErrorMessage = "Professor Last Name cannot be blank")]
        [Column(Order = 2, TypeName = "nvarchar(50)")]
        public string ProfessorLName { get; set; }

        [Required(ErrorMessage = "Date of Birth can't be blank and has to be from 1900 to 2019")]
        [Column(Order = 3, TypeName = "date")]
        [Range(1900, 2019)]
        public DateTime ProfessorDOB { get; set; }

        [Required(ErrorMessage = "Phone cannot be blank")]
        [Column(Order = 4, TypeName = "int")]
        public int ProfessorPhone { get; set; }

        [Required(ErrorMessage = "Professor Address cannot be blank")]
        [Column(Order = 5, TypeName = "nvarchar(150)")]
        public string ProfessorAdd { get; set; }
    }
}

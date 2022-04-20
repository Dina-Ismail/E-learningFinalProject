using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_learningFinalProject.Models
{
    public class CreateRoleViewModel :IdentityRole
    {
        [Required]
        public string RoleName { get; set; }
        
    }
}

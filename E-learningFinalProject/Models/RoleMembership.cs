using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_learningFinalProject.Models
{
    public class RoleMembership
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<IdentityUser> RoleMembers { get; set;}
        public IEnumerable<IdentityUser> RoleNonMembers { get; set; }

    }
}

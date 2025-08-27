using EducationalPlatform.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatform.Infrastructure
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
        public string UserType { get; set; } = string.Empty;
        public Student student {  get; set; }
        public Teacher teacher {  get; set; }
       


        
    }
}

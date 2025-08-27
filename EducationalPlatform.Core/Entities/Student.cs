
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatform.Core.Entities
{
    public class Student
    {

        public string FirstName { set; get; }
        public string LastName { get; set; }
       public int Id { get; set; }
        public Guid UserId { get; set; }
        
        public int LevelId { get; set; }
        public Level Level { get; set; }
       

    }
}

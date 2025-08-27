using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatform.Core.Entities
{
    public class LectureExam
    {
        public int LectureId { get; set; }  
        public int Id { get; set; } 
        public string Title { get; set; }
        public ICollection<Question> Questions { get; set; }    
        public Lecture Lecture { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatform.Core.Entities
{
    public   class Exam
    {
        public int Id { get; set; }
        public int LectureId { get; set; }  
        public string Title { get; set; }   
        public  string ExamFileUrl { get; set; }    

    }
}

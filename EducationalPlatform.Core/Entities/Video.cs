using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatform.Core.Entities
{
    public class Video


    {
        public int Id { get; set; }
        public string Url { get; set; }
       public int LectureId { get; set; }   
        public Lecture Lecture { get; set; }

    }
}

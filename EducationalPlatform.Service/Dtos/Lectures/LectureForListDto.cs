using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatform.Application.Dtos.Lectures
{
    public class LectureForListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
       public int LevelId { get; set; }
    }
}

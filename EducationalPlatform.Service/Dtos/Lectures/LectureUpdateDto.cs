using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatform.Application.Dtos.Lectures
{
    public class LectureUpdateDto
    {
        
            public int Id { get; set; }  
            public string Name { get; set; }
            public string Description { get; set; }
            public string VideoUrl { get; set; }
            public DateTime Date { get; set; }
            public int LevelId { get; set; }
        }

    }


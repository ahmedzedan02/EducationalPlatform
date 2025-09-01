using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationalPlatform.Core.Entities;

namespace EducationalPlatform.Application.Dtos.Lectures
{
    public class LectureCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int LevelId { get; set; }
        public string VideoUrl { get; set; }
        public DateTime Date { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPlatform.Core.Entities
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
         public DateTime Date { get; set; }
        public Video Video { get; set; }
        public int LevelId { get; set; }
  public int VideoId { get; set; }  
        public Level Level { get; set; }
          public int TeacherId { get; set; } 
        public Teacher Teacher { get; set; }
    }
}

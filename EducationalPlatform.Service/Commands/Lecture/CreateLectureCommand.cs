using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace EducationalPlatform.Application.Commands.Lecture
{
    public class CreateLectureCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public int LevelId { get; set; }
        public int TeacherId { get; set; }
        public string VideoUrl { get; set; } 
      //  public CreateQuizDto Quiz { get; set; }

    }
}

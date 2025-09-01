using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace EducationalPlatform.Application.Commands.Lecture
{
    public class DeleteLectureCommand : IRequest<bool>
    {
        public int Id { get; set; }

    }
}

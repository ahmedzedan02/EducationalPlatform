using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationalPlatform.Application.Dtos.Lectures;
using MediatR;

namespace EducationalPlatform.Application.Queries.Lectures
{
    public class GetLectureByIdQuery : IRequest<LectureForListDto>
    {
        public int Id { get; set; }
    }
}

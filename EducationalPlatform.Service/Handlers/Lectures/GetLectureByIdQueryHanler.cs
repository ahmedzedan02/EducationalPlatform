using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationalPlatform.Core.Entities;
using EducationalPlatform.Core.Interfaces;
using MediatR;

namespace EducationalPlatform.Application.Handlers.Lectures
{
    public record GetLectureByIdQuery(Guid Id) : IRequest<Lecture>;

    public class GetLectureByIdHandler : IRequestHandler<GetLectureByIdQuery, Lecture>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetLectureByIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Lecture> Handle(GetLectureByIdQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Repository<Lecture>().GetByIdAsync(request.Id);
        }
    }
}

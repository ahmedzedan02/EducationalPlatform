using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationalPlatform.Application.Commands.Lecture;
using EducationalPlatform.Core.Entities;
using EducationalPlatform.Core.Interfaces;
using MediatR;

namespace EducationalPlatform.Application.Handlers.Lectures
{
    public record UpdateLectureCommand(Guid Id, string Title, int LevelId) : IRequest<Lecture>;

    public class UpdateLectureHandler : IRequestHandler<UpdateLectureCommand, Lecture>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateLectureHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Lecture> Handle(UpdateLectureCommand request, CancellationToken cancellationToken)
        {
            var lecture = await _unitOfWork.Repository<Lecture>().GetByIdAsync(request.Id);
            if (lecture == null) return null;

            lecture.Name = request.Title;
            lecture.LevelId = request.LevelId;

             _unitOfWork.Repository<Lecture>().Update(lecture);
            await _unitOfWork.CompleteAsync();

            return lecture;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationalPlatform.Application.Commands.Lecture;
using EducationalPlatform.Core.Entities;
using EducationalPlatform.Core.Interfaces;
using MediatR;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

namespace EducationalPlatform.Application.Handlers.Lectures
{
    public record CreateLectureCommand(string Title, int LevelId) : IRequest<Lecture>;

    public class CreateLectureHandler : IRequestHandler<CreateLectureCommand, Lecture>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateLectureHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Lecture> Handle(CreateLectureCommand request, CancellationToken cancellationToken)
        {
            var lecture = new Lecture
            {
                Name = request.Title,
                LevelId = request.LevelId
            };

            await _unitOfWork.Repository<Lecture>().AddAsync(lecture);
            await _unitOfWork.CompleteAsync();
            return lecture;
        }
    }
}

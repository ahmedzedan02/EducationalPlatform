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
    public record DeleteLectureCommand(Guid Id) : IRequest<bool>;

    public class DeleteLectureCommandHandler : IRequestHandler<DeleteLectureCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteLectureCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteLectureCommand request, CancellationToken cancellationToken)
        {
            var lecture = await _unitOfWork.Repository<Lecture>().GetByIdAsync(request.Id);
            if (lecture == null) return false;

            _unitOfWork.Repository<Lecture>().Delete(lecture);
            await _unitOfWork.CompleteAsync();

            return true;
        }
    }
}
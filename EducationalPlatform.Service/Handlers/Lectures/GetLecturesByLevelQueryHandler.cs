using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EducationalPlatform.Core.Entities;
using EducationalPlatform.Core.Interfaces;
using MediatR;

namespace EducationalPlatform.Application.Handlers.Lectures
{
    public record GetLecturesByLevelQuery(int LevelId) : IRequest<IEnumerable<Lecture>>;

    // Handler
    public class GetLecturesByLevelHandler : IRequestHandler<GetLecturesByLevelQuery, IEnumerable<Lecture>>
    {
        private readonly ILectureRepository _lectureRepository;

        public GetLecturesByLevelHandler(ILectureRepository lectureRepository)
        {
            _lectureRepository = lectureRepository;
        }

        public async Task<IEnumerable<Lecture>> Handle(GetLecturesByLevelQuery request, CancellationToken cancellationToken)
        {
            return await _lectureRepository.GetLecturesByLevelAsync(request.LevelId);
        }
    }
}

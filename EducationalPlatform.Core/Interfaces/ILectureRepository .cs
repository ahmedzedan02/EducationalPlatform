using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationalPlatform.Core.Entities;

namespace EducationalPlatform.Core.Interfaces
{
    public interface ILectureRepository : IGenericRepository<Lecture>
    {
        Task<IEnumerable<Lecture>> GetLecturesByLevelAsync(int levelId);
    }
}

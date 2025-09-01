using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationalPlatform.Core.Entities;
using EducationalPlatform.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EducationalPlatform.Infrastructure.Repositories
{
    public  class LectureRepository : GenericRepository<Lecture> , ILectureRepository
    {
        private readonly AppDbContext _context;
        public LectureRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Lecture>> GetLecturesByLevelAsync(int levelId)
        {
            return await _context.Lectures
                .Where(l => l.LevelId == levelId)
                .ToListAsync();
        }

       
    }
}

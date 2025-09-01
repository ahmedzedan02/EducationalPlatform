using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationalPlatform.Core.Entities;
using EducationalPlatform.Core.Interfaces;

namespace EducationalPlatform.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private Hashtable _repositories;


        public ILectureRepository Lectures { get; private set; }

        public UnitOfWork(AppDbContext context,ILectureRepository lectureRepository)
        {
            _context = context;
            Lectures = lectureRepository;
            _repositories = new Hashtable();
        }
        public IGenericRepository<T> Repository<T>() where T : class
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);
                _repositories.Add(type, repositoryInstance);
            }

            return (IGenericRepository<T>)_repositories[type];
        }
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
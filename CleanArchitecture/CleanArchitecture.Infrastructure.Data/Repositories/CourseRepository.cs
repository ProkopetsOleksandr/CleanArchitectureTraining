using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using System.Collections.Generic;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _dbContext;

        public CourseRepository(UniversityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _dbContext.Courses;
        }
    }
}

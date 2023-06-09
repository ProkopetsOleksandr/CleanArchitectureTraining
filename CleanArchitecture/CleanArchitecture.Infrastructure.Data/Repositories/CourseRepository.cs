﻿using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _dbContext;

        public CourseRepository(UniversityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Course course)
        {
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
        }

        public IQueryable<Course> GetCourses()
        {
            return _dbContext.Courses;
        }
    }
}

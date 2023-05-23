using CleanArchitecture.Aplication.Interfaces;
using CleanArchitecture.Aplication.ViewModels;
using CleanArchitecture.Domain.Interfaces;
using System.Collections.Generic;

namespace CleanArchitecture.Aplication.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}

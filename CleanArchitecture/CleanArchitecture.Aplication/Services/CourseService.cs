using CleanArchitecture.Aplication.Interfaces;
using CleanArchitecture.Aplication.ViewModels;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Bus;

namespace CleanArchitecture.Aplication.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;


        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }

        public void Create(CourseViewModel model)
        {
            var createCourseCommand = new CreateCourseCommand(model.Name, model.Description, model.ImageUrl);
            _bus.SendCommandAsync(createCourseCommand);
        }
    }
}

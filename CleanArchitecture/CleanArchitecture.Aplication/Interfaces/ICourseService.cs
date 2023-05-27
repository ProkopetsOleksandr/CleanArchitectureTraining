using CleanArchitecture.Aplication.ViewModels;

namespace CleanArchitecture.Aplication.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
        void Create(CourseViewModel model);
    }
}

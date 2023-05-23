using CleanArchitecture.Aplication.ViewModels;
using System.Collections.Generic;

namespace CleanArchitecture.Aplication.Interfaces
{
    public interface ICourseService
    {
        IReadOnlyCollection<CourseViewModel> GetCourses(); 
    }
}

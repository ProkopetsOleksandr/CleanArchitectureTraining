using CleanArchitecture.Domain.Models;
using System.Collections.Generic;

namespace CleanArchitecture.Aplication.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}

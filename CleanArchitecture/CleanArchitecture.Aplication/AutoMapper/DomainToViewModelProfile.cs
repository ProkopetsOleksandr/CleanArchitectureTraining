using AutoMapper;
using CleanArchitecture.Aplication.ViewModels;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Aplication.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}

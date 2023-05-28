using AutoMapper;
using CleanArchitecture.Aplication.ViewModels;
using CleanArchitecture.Domain.Commands;

namespace CleanArchitecture.Aplication.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(c => new CreateCourseCommand(c.Name, c.Description, c.ImageUrl));
        }
    }
}

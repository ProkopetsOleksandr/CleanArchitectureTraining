using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitecture.Aplication.Interfaces;
using CleanArchitecture.Aplication.ViewModels;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Bus;
using System.Collections.Generic;

namespace CleanArchitecture.Aplication.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _mapper = mapper;
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses()
                .ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);
        }

        public void Create(CourseViewModel model)
        {
            _bus.SendCommandAsync(_mapper.Map<CreateCourseCommand>(model));
        }
    }
}

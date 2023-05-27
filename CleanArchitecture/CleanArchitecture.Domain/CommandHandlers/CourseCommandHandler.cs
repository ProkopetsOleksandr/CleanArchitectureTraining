using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _courseRepository;

        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            _courseRepository.Add(new Course
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            });

            return Task.FromResult(true);
        }
    }
}

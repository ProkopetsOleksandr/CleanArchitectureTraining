using CleanArchitecture.Aplication.Interfaces;
using CleanArchitecture.Aplication.Services;
using CleanArchitecture.Domain.CommandHandlers;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Bus;
using CleanArchitecture.Infrastructure.Data.Context;
using CleanArchitecture.Infrastructure.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterServises(IServiceCollection services)
        {
            // Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Domain Handlers
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            // Application layer
            services.AddScoped<ICourseService, CourseService>();

            // Infrastructure.Data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDbContext>();
        }
    }
}

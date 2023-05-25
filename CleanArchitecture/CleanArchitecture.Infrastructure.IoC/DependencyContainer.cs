using CleanArchitecture.Aplication.Interfaces;
using CleanArchitecture.Aplication.Services;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterServises(IServiceCollection services)
        {
            // Application layer
            services.AddScoped<ICourseService, CourseService>();

            // Infrastructure.Data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}

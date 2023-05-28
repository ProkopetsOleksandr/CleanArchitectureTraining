using CleanArchitecture.Aplication.Interfaces;
using CleanArchitecture.Aplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CourseViewModel model)
        {
            _courseService.Create(model);

            return Ok(model);
        }
    }
}

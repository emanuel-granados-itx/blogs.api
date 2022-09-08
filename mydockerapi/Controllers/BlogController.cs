using Microsoft.AspNetCore.Mvc;
using mydockerapi.Services.Interfaces;

namespace mydockerapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_blogService.GetBlogs());
        }
    }
}

using mydockerapi.Data.Repository.Interfaces;
using mydockerapi.Services.Interfaces;

namespace mydockerapi.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _repository;

        public BlogService(IBlogRepository repository)
        {
            _repository = repository;
        }

        public List<Blog> GetBlogs() 
        {
            return _repository.GetBlogs();
        }
    }
}

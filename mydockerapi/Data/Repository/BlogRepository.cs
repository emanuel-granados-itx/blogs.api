using mydockerapi.Data.Repository.Interfaces;

namespace mydockerapi.Data.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly ApiDbContext _context;

        public BlogRepository(ApiDbContext context)
        {
            _context = context;
        }

        public List<Blog> GetBlogs()
        {
            return _context.Blogs.ToList();
        }
    }
}

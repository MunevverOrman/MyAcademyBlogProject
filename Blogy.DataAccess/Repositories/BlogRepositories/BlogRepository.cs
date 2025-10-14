using Blogy.DataAccess.Context;
using Blogy.DataAccess.Repositories.GenericRepositories;
using Blogy.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blogy.DataAccess.Repositories.BlogRepositories
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        public BlogRepository(AppDbContext context) : base(context) //Genericrepository'den miras alır
        {
        }

        public async Task<List<Blog>> GetBlogsWithCategoriesAsync()
        {
            return await _table.Include(x=>x.Category).ToListAsync();
        }
    }
}

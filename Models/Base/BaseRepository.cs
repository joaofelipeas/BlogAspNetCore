using Blog.Context;
using Microsoft.EntityFrameworkCore;

namespace Blog.Models.Base
{
    public abstract class BaseRepository<T> where T : BaseModel
    {
        protected readonly ContextDb _context;

        protected readonly DbSet<T> DbSet;

        public BaseRepository(ContextDb contextDb)
        {
            _context = contextDb;
            DbSet = contextDb.Set<T>();
        }
    }
}
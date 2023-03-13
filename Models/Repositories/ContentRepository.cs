using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Context;
using Blog.Models.Base;
using Blog.Models.Entities;
using Blog.Models.Repositories.IRepositories;

namespace Blog.Models.Repositories
{
    public class ContentRepository : BaseRepository<Content>, IContentRepository
    {
        protected readonly ContextDb _context;
        public ContentRepository(ContextDb contextDb) : base(contextDb)
        {
            _context = contextDb;
        }

        public Task<IEnumerable<Content>> GetContents()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertContent(Content content)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveContent(Content content)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateContent(Content content)
        {
            throw new NotImplementedException();
        }
    }
}
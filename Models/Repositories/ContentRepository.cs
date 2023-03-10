using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Context;
using Blog.Models.Base;
using Blog.Models.Entities;
using Blog.Models.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Blog.Models.Repositories
{
    public class ContentRepository : BaseRepository<Content>, IContentRepository
    {
        private readonly ContextDb _context;
        public ContentRepository(ContextDb contextDb) : base(contextDb)
        {
            _context = contextDb;
        }

        public async Task<IEnumerable<Content>> GetContents()
        {
            return await _context.Contents.ToListAsync();
        }

        public async Task<bool> InsertContent(Content content)
        {
            try
            {
                _context.Contents.Add(content);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }

        }

        public async Task<bool> RemoveContent(Content content)
        {
            try
            {
                _context.Contents.Remove(content);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }

        public async Task<bool> UpdateContent(Content content)
        {
            try
            {
                _context.Contents.Update(content);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Context;
using Blog.Models.Base;
using Blog.Models.Entities;
using Blog.Models.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Blog.Models.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        private readonly ContextDb _context;

        public CommentRepository(ContextDb contextDb) : base(contextDb)
        {
            _context = contextDb;
        }

        public async Task<IEnumerable<Comment>> GetComments()
        {
            return await _context.Comments.ToListAsync();
        }

        public async Task<bool> InsertComment(Comment comment)
        {
            try
            {
                _context.Comments.Add(comment);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }

        public async Task<bool> RemoveComment(Comment comment)
        {
            try
            {
                _context.Comments.Remove(comment);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }

        public async Task<bool> UpdateComment(Comment comment)
        {
            try
            {
                _context.Comments.Update(comment);
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
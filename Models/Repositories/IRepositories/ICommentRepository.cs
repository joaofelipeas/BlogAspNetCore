using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models.Entities;

namespace Blog.Models.Repositories.IRepositories
{
    public interface ICommentRepository
    {
        Task<IEnumerable<Comment>> GetComments();

        Task<bool> InsertComment(Comment comment);

        Task<bool> RemoveComment(Comment comment);

        Task<bool> UpdateComment(Comment comment);
    }
}
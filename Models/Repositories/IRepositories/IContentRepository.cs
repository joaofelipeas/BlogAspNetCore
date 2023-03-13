using System.Collections.Generic;
using System.Threading.Tasks;
using Blog.Models.Entities;

namespace Blog.Models.Repositories.IRepositories
{
    public interface IContentRepository
    {
        Task<IEnumerable<Content>> GetContents();

        Task<bool> InsertContent(Content content);

        Task<bool> RemoveContent(Content content);

        Task<bool> UpdateContent(Content content);
    }
}
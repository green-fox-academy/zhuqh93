using System.Collections.Generic;
using System.Threading.Tasks;
using reddit_project.Models;

namespace reddit_project.Services
{
    public interface IPostServices
    {
        Task<IEnumerable<Post>> FindAll();
        Task Add(Post post);
        Task UpVote(long id);
        Task DownVote(long id);

        //        void Add(string title, string url);
    }
}
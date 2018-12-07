using System.Collections.Generic;
using reddit_project.Models;

namespace reddit_project.Services
{
    public interface IPostServices
    {
        IEnumerable<Post> FindAll();
        void Add(Post post);
        void UpVote(long id);
        void DownVote(long id);

        //        void Add(string title, string url);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using reddit_project.Models;

namespace reddit_project.Services
{
    public class PostServices : IPostServices
    {
        public readonly ApplicationContext ApplicationContext;

        public PostServices(ApplicationContext applicationContext)
        {
            this.ApplicationContext = applicationContext;
        }

        public IEnumerable<Post> FindAll()
        {
            return ApplicationContext.Posts;
        }

        public void Add(Post post)
        {
            Post newPost = new Post
            {
                Title = post.Title,
                Url = post.Url
            };

            ApplicationContext.Posts.Add(newPost);
            ApplicationContext.SaveChanges();
        }

        public void UpVote(long id)
        {
            var postFromTheDB = ApplicationContext.Posts.Find(id);
            postFromTheDB.Vote++;
            ApplicationContext.SaveChanges();
        }

        public void DownVote(long id)
        {
            var postFromTheDB = ApplicationContext.Posts.Find(id);
            postFromTheDB.Vote--;
            ApplicationContext.SaveChanges();
        }

        //        public void Add(string title, string url)
        //        {
        //            Post newPost = new Post
        //            {
        //                Title = title,
        //                Url = url
        //            };
        //
        //            ApplicationContext.Posts.Add(newPost);
        //            ApplicationContext.SaveChanges();
        //        }
    }
}

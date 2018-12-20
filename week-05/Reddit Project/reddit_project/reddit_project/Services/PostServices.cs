using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Post>> FindAll()
        {
            return await ApplicationContext.Posts.ToListAsync();
        }

        public async Task Add(Post post)
        {
            Post newPost = new Post
            {
                Title = post.Title,
                Url = post.Url
            };

            await ApplicationContext.Posts.AddAsync(newPost);
            await ApplicationContext.SaveChangesAsync();
        }

        public async Task UpVote(long id)
        {
            var postFromTheDB = await ApplicationContext.Posts.FindAsync(id);
            postFromTheDB.Vote++;
            await ApplicationContext.SaveChangesAsync();
        }

        public async Task DownVote(long id)
        {
            var postFromTheDB = await ApplicationContext.Posts.FindAsync(id);
            postFromTheDB.Vote--;
            await ApplicationContext.SaveChangesAsync();
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

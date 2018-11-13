using System;
using System.Collections.Generic;
using System.Text;

namespace week02_day02
{
    class Blog
    {
        private List<BlogPost> blogPosts;

        public Blog()
        {
            blogPosts = new List<BlogPost>();
        }

        public void Add(BlogPost blogPost)
        {
            blogPosts.Add(blogPost);
        }

        public void Delete(int index)
        {
            blogPosts.RemoveAt(index);
        }

        public void Update(int index, BlogPost blogPost)
        {
            this.Delete(index);
            this.Add(blogPost);
        }
    }
}

using System;

namespace reddit_project.Models
{
    public class Post
    {
        public long PostId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Url { get; set; }
        public long Vote { get; set; }
        public DateTime CreateDateTime { get; set; }

        public Post()
        {
            CreateDateTime = DateTime.Now;
        }
    }
}
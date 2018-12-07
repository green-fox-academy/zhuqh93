using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using reddit_project.Models;

namespace reddit_project.ViewModels
{
    public class ViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public int PageCount { get; set; }
        public int PageIndex { get; set; }
    }
}

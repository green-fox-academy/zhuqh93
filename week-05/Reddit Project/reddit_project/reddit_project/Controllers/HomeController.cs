using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using reddit_project.Models;
using reddit_project.Services;
using reddit_project.ViewModels;

namespace reddit_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostServices postServices;

        public HomeController(IPostServices postServices)
        {
            this.postServices = postServices;
        }

        [HttpGet("")]
        public IActionResult Index(int pageIndex)
        {
            ViewModel model = new ViewModel();
            model.Posts = postServices.FindAll();
            model.PageCount = model.Posts.Count();
            model.PageIndex = pageIndex == 0 ? 1 : pageIndex;

            return View(model);
        }

        [HttpGet]
        public IActionResult UpVote(int postId, int pageIndex)
        {
            postServices.UpVote(postId);

            return RedirectToAction("Index", new { pageIndex = pageIndex });
        }

        [HttpGet]
        public IActionResult DownVote(int postId, int pageIndex)
        {
            postServices.DownVote(postId);

            return RedirectToAction("Index", new { pageIndex = pageIndex });
        }

        [HttpGet("submit")]
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost("submit")]
        public IActionResult Submit(Post post)
        {
            postServices.Add(post);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

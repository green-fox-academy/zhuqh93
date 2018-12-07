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

        [HttpPost]
        public IActionResult UpVote(int id)
        {
            postServices.UpVote(id);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DownVote(int id)
        {
            postServices.DownVote(id);

            return RedirectToAction("Index");
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

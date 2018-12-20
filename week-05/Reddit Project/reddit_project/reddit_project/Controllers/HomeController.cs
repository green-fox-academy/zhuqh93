using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IActionResult> Index(int pageIndex)
        {
            ViewModel model = new ViewModel();
            model.Posts = await postServices.FindAll();
            model.PageCount = model.Posts.Count();
            model.PageIndex = pageIndex == 0 ? 1 : pageIndex;

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UpVote(int postId, int pageIndex)
        {
            await postServices.UpVote(postId);

            return RedirectToAction("Index", new { pageIndex = pageIndex });
        }

        [HttpGet]
        public async Task<IActionResult> DownVote(int postId, int pageIndex)
        {
            await postServices.DownVote(postId);

            return RedirectToAction("Index", new { pageIndex = pageIndex });
        }

        [HttpGet("submit")]
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost("submit")]
        public async Task<IActionResult> Submit(Post post)
        {
            await postServices.Add(post);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

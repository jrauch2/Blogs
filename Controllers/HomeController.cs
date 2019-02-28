using System.Linq;
using Blogs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogs.Controllers
{
    public class HomeController : Controller
    {
        // this controller depends on the BloggingRepository
        private IBloggingRepository repository;
        public HomeController(IBloggingRepository repo) => repository = repo;

        public IActionResult Index() => View(repository.Blogs.OrderBy(b => b.Name));

        public IActionResult AddBlog() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddBlog(Blog model)
        {
            repository.AddBlog(model);
            return RedirectToAction("Index");
        }
    }
}

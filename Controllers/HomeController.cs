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
            if (ModelState.IsValid)
            {
                if (repository.Blogs.Any(b => b.Name == model.Name))
                {
                    ModelState.AddModelError("", "Name must be unique");
                }
                else
                {
                    repository.AddBlog(model);
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            repository.DeleteBlog(repository.Blogs.FirstOrDefault(b => b.BlogId == id));
            return RedirectToAction("Index");
        }
    }
}

using System.Linq;
using BlogOdev.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogOdev.Web.Controllers
{
    public class ModuleController : Controller
    {
        private readonly BlogContext _blogContext;
        public ModuleController(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }
        public IActionResult Categories()
        {
            var categories = _blogContext.Categories.Include(a => a.Blogs).OrderBy(a => a.Name).ToList();
            return View(categories);
        }
    }
}
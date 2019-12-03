using System.Linq;
using BlogOdev.Data.Context;
using BlogOdev.Data.Enums;
using BlogOdev.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogOdev.Web.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly BlogContext _blogContext;
        public AboutUsController(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }
        public IActionResult Index()
        {
            Page page = _blogContext.Pages.FirstOrDefault(a=>!a.Deleted && a.PageKind== PageKind.About);
            return View(page);
        }
    }
}
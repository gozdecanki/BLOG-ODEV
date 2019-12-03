using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogOdev.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace BlogOdev.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogContext _blogContext;
        public HomeController(BlogContext blogContext)
        {
            _blogContext = blogContext;

        }
        public IActionResult Index()
        {
            List<BlogOdev.Data.Models.Blog> blogs =  _blogContext.Blogs.OrderByDescending(a => a.CreateDate).ToList();
            return View(blogs);
        }
    }
}
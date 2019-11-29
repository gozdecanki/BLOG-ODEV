using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogOdev.Data.Context;
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
            Page page = _blogContext.Pages.FirstOrDefault(a=>!a.Deleted && a.PageKind==Data.Enums.PageKind.About);
            return View(page);
        }
    }
}
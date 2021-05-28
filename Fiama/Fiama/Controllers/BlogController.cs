using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fiama.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Pages = "Blog";
            return View();
        }
        public IActionResult BlogDetails()
        {
            ViewBag.Pages = "BlogDetails";
            return View();
        }
    }
}
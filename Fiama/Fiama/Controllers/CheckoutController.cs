using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fiama.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Pages = "Checkout";
            return View();
        }
    }
}
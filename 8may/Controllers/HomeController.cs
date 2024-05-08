using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _8may.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}

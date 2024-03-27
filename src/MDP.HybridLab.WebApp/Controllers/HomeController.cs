using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MDP.HybridLab.WebApp
{
    public class HomeController : Controller
    {
        // Methods
        public IActionResult Index()
        {
            // Return
            return View();
        }
    }
}

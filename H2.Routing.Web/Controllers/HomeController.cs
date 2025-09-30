using System.Diagnostics;
using H2.Routing.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace H2.Routing.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ShowId(int id)
        {
            return Content($"You wanted id: {id}");
        }

        public IActionResult SearchById(int id)
        {
            return Content($"You searched for product id: {id}");
        }

        public IActionResult SearchByName(string name)
        {
            return Content($"You searched for product name: {name}");
        }

        public IActionResult ShowUserInfo(int id, string username)
        {
            return Content($"User ID: {id} en Username: {username}");
        }
    }
}

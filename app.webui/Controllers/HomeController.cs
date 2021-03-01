using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    // localhost:5000/home
    public class HomeController : Controller
    {
        // localhost:5000/home/index
        public IActionResult Index() // action
        {
            return View();
        }
        // localhost:5000/home/about
        public IActionResult About() // action
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}
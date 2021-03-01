using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    // localhost:5000/home
    public class HomeController : Controller
    {
        // localhost:5000/home/index
        public string Index() // action
        {
            return "home/index";
        }
        // localhost:5000/home/about
        public string About() // action
        {
            return "home/about";
        }
    }
}
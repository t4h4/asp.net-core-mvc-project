using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index() // action
        {
            return View();
        }
        // localhost:5000/product/list
        public IActionResult list() // action   
        {
            return View();
        }
        // localhost:5000/product/details/2
        public string Details(int id) // action
        {
            return "product/details/" + id;
        }
    }
}
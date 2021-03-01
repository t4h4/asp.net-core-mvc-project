using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    public class ProductController : Controller
    {
        public string Index() // action
        {
            return "product/index";
        }
        // localhost:5000/product/list
        public string list() // action   
        {
            return "product/list";
        }
        // localhost:5000/product/details/2
        public string Details(int id) // action
        {
            return "product/details/" + id;
        }
    }
}
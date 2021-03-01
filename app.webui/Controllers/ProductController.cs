using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    public class ProductController : Controller
    {
        // localhost:5000/product/list
        public string list()
        {
            return "product/list";
        }
        // localhost:5000/product/details
        public string Details()
        {
            return "product/details";
        }
    }
}
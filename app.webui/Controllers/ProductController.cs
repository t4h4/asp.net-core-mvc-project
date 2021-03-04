using System.Collections.Generic;
using System.Linq;
using app.webui.Data;
using app.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index() // action
        {
            // ViewBag
            // Model
            // ViewData

            var product = new Product { Name = "xiaomi mi", Price = 3000, Description = "f/p telefon" };

            // ViewData["Product"] = product;
            // ViewData["Category"] = "Telefon";

            ViewBag.Category = "Telefon";
            // ViewBag.Product = product;

            return View(product);
        }
        // localhost:5000/product/list

        // product/list => tüm ürünleri (sayfalama)
        // product/list/2 => 2 numaralı kategoriye ait ürünler
        public IActionResult list(int? id) 
        {
            // {controller}/{action}/{id?}
            // product/list/3
            // RouteData.Values["controller"] => product
            // RouteData.Values["action"] => list
            // RouteData.Values["id"] => 3

            // Console.WriteLine(RouteData.Values["controller"]);
            // Console.WriteLine(RouteData.Values["action"]);
            // Console.WriteLine(RouteData.Values["id"]);

            var products = ProductRepository.Products;

            if (id != null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
        }
        // localhost:5000/product/details/2
        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }
    }
}
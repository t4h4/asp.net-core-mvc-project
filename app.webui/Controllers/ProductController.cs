using System.Collections.Generic;
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
        public IActionResult list() // action   
        {
            var products = new List<Product>()
            {
                new Product {Name="Iphone 7",Price=3000,Description="iyi telefon",IsApproved=false},
                new Product {Name="Iphone 8",Price=4000,Description="çok iyi telefon",IsApproved=true},
                new Product {Name="Iphone X",Price=5000,Description="çok iyi telefon",IsApproved=true},
                new Product {Name="Iphone 11",Price=7000,Description="çok iyi telefon"},
            };

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };
            return View(productViewModel);
        }
        // localhost:5000/product/details/2
        public IActionResult Details(int id) // action
        {
            // ViewBag.Name = "iphone 12";
            // ViewBag.Price = 12000;
            // ViewBag.Description = "telefon";

            var p = new Product(); // product modeli eklendi.
            p.Name = "iphone 12";
            p.Price = 13000;
            p.Description = "telefon";

            return View(p);
        }
    }
}
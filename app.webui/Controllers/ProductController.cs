using System.Collections.Generic;
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
        public IActionResult list() // action   
        {
            var productViewModel = new ProductViewModel()
            {
                Products = ProductRepository.Products
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
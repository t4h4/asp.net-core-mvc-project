using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using app.webui.Models;
using app.webui.Data;

namespace app.webui.Controllers
{
    // localhost:5000/home
    public class HomeController:Controller
    {      
        public IActionResult Index()
        {
            var productViewModel = new ProductViewModel()
            {
                Products = ProductRepository.Products
            };

            return View(productViewModel);
        }

         // localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }

         public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}
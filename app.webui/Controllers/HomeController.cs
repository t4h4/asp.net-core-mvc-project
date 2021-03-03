using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using app.webui.Models;

namespace app.webui.Controllers
{
    // localhost:5000/home
    public class HomeController:Controller
    {      
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product {Name="Iphone 7",Price=3000,Description="iyi telefon",IsApproved=false},
                new Product {Name="Iphone 8",Price=4000,Description="çok iyi telefon",IsApproved=true},
                new Product {Name="Iphone X",Price=5000,Description="çok iyi telefon",IsApproved=true},
                new Product {Name="Iphone 11",Price=7000,Description="çok iyi telefon"},
            };

            var categories = new List<Category>()
            {
                new Category {Name="Telefon",Description="Telefon Kategorisi"},
                new Category {Name="Bilgisayar",Description="Bilgisayar Kategorisi"},
                new Category {Name="Elektronik",Description="Elektronik Kategorisi"}
            };

            var productViewModel = new ProductViewModel()
            {
                Categories = categories,
                Products = products
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
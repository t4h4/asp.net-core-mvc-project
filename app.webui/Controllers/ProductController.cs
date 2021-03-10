using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using app.webui.Data;
using app.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            var product = new Product {Name="Iphone X",Price=6000,Description="güzel telefon"};
            ViewBag.Category = "Telefonlar";

            return View(product);
        }
        public IActionResult list(int? id,string q,double? min_price,double? max_price) 
        {
            var products = ProductRepository.Products;

            if (id!=null)
            {
                products = products.Where(p=>p.CategoryId==id).ToList();
            }

            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(i=>i.Name.Contains(q) || i.Description.Contains(q)).ToList();
            }

            var productViewModel = new ProductViewModel()
            {
                Products =products
            };

            return View(productViewModel);
        }

        //eklemesek bile bu metodlarrın varsayılanları hep http get
        [HttpGet] 
        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {           
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {           
            ProductRepository.AddProduct(p);
            return RedirectToAction("list"); // kayıt yapıldıktan sonra ürün listelemesine git.
        }


        
    }
}
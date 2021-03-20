using System.Linq;
using app.business.Abstract;
using app.entity;
using app.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace app.webui.Controllers
{
    public class ShopController : Controller
    {
        //product service kullanmak için aşağıda inject işlemi yapıyoruz. constructor dahil.
        private IProductService _productService;
        public ShopController(IProductService productService)
        {
            this._productService = productService;
        }

        public IActionResult List()
        {
            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetAll()
            };

            return View(productViewModel);
        }

        public IActionResult Details(int? id) //her zaman id gelmesi beklenmez.
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetails((int)id); // nullable değil. cast etmemiz gerek. 

            if (product == null) //gönderilen ürün bulunamadıysa
            {
                return NotFound();
            }

            //aşağıda veritabanı sorgulamayoruz, gelen değerleri gönderiyoruz.
            return View(new ProductDetailModel{
                Product = product,
                Categories = product.ProductCategories.Select(i=>i.Category).ToList()
            });
        }
    }
}
using app.business.Abstract;
using app.entity;
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
            Product product = _productService.GetById((int)id); // nullable değil. cast etmemiz gerek. 

            if (product == null) //gönderilen ürün bulunamadıysa
            {
                return NotFound();
            }
            return View(product); //bulunduysa bulunan product bilgisini sayfaya model olarak gönderelim.
        }
    }
}
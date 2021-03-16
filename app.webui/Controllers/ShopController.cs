using app.business.Abstract;
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
    }
}
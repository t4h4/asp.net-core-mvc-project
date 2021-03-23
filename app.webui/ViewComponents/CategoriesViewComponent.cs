using System.Collections.Generic;
using app.business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace app.webui.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        //inject işlemi yapıyoruz aşağıda.
        private ICategoryService _categoryService;
        public CategoriesViewComponent(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {

            if (RouteData.Values["category"] != null)
                ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(_categoryService.GetAll());

        }
    }
}
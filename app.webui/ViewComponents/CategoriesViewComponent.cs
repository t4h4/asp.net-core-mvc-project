using System.Collections.Generic;
using app.webui.Data;
using app.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace app.webui.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["action"].ToString() == "list")
                ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
        }
    }
}
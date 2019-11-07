using Microsoft.AspNetCore.Mvc;
using _7fotograf.ComponentPaths;
namespace _7fotograf.Components
{
    [ViewComponent(Name = "categorycontainer")]
    public class CategoryContainer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(HtmlViewsPaths.categorycontainer);
        }
    }
}
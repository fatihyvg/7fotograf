using Microsoft.AspNetCore.Mvc;
using _7fotograf.ComponentPaths;
namespace _7fotograf.Components
{
    [ViewComponent(Name = "categoryheader")]
    public class CategoryHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(HtmlViewsPaths.categoryheader);
        }
    }
}
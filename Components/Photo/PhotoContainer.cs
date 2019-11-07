using Microsoft.AspNetCore.Mvc;
using _7fotograf.ComponentPaths;
namespace _7fotograf.Components
{
    [ViewComponent(Name = "photocontainer")]
    public class PhotoContainer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(HtmlViewsPaths.photocontainer);
        }
    }
}
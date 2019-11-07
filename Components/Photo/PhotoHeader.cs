using Microsoft.AspNetCore.Mvc;
using _7fotograf.ComponentPaths;
namespace _7fotograf.Components
{
    [ViewComponent(Name = "photoheader")]
    public class PhotoHeaderController : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(HtmlViewsPaths.photoheader);
        }
    }
}
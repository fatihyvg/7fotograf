using Microsoft.AspNetCore.Mvc;
using _7fotograf.ComponentPaths;
namespace _7fotograf.Components
{
    [ViewComponent(Name="footer")]
    public class Footer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(HtmlViewsPaths.homefooter);
        }
    }
}
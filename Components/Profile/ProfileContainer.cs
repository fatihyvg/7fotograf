using Microsoft.AspNetCore.Mvc;
using _7fotograf.ComponentPaths;
namespace _7fotograf.Components
{
    [ViewComponent(Name = "profilecontainer")]
    public class ProfileContainer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(HtmlViewsPaths.profilecontainer);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using _7fotograf.ComponentPaths;
namespace _7fotograf.Components
{
    [ViewComponent(Name = "profileheader")]
    public class ProfileHeader : ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View(HtmlViewsPaths.profileheader);
        }
    }
}
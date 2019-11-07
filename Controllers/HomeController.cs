using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
namespace _7fotograf.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
         [AllowAnonymous]
        public ActionResult Login(string returnUrl,string provider)
        {
               AuthenticationProperties authprop = new AuthenticationProperties();
               authprop.RedirectUri = Url.Action("login","List");
               return Challenge(authprop,provider);          
        }
        public async  Task<ActionResult> LogOut()
        {
           await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
           HttpContext.Session.Clear();
           return RedirectToAction("Index","Home"); 
        }
        
    }
}
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _7fotograf.ComponentPaths;
using _7fotograf.Models;
using _7fotograf.Interfaces;
namespace _7fotograf.Components
{
    [ViewComponent(Name="listheader")]
    public class ListHeader : ViewComponent
    {
        List<FacebookLogin> facebookLogin;

        IFacebookLogin log;
        public ListHeader(IFacebookLogin log)
        {
            this.log = log;
        }
        public IViewComponentResult Invoke()
        {
            var fbtype = HttpContext.User as ClaimsPrincipal;

            if(fbtype == null) { throw null; };
            
            facebookLogin = new List<FacebookLogin>();
            this.log.UserFbId = fbtype.FindFirstValue(ClaimTypes.NameIdentifier);
            this.log.UserName = fbtype.FindFirstValue(ClaimTypes.Name);
            this.log.UserEmail = fbtype.FindFirstValue(ClaimTypes.Email);
            facebookLogin.Add((FacebookLogin)this.log);

            if(this.log.UserFbId != null && this.log.UserName != null && this.log.UserEmail != null)
            {
                  HttpContext.Session.SetString("Id",fbtype.FindFirstValue(ClaimTypes.NameIdentifier));
                  HttpContext.Session.SetString("name",fbtype.FindFirstValue(ClaimTypes.Name));
                  HttpContext.Session.SetString("email",fbtype.FindFirstValue(ClaimTypes.Email));
            }
            else
            {
                if(this.log.UserFbId == null && this.log.UserName == null && this.log.UserEmail == null)
                {
                    Url.Action("Index","Home");
                }
            }

            return View(HtmlViewsPaths.listheader,facebookLogin);
        }
    }
}
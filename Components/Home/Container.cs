using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _7fotograf.Database;
using _7fotograf.Models;
using _7fotograf.Interfaces;
using _7fotograf.ComponentPaths;
namespace _7fotograf.Components
{
    [ViewComponent(Name="container")]
    public class Container : ViewComponent,IListContent<ImagePosition>
    {
        Connection connection;
        public Container(Connection connection)
        {
            this.connection = connection;
        }
        public IViewComponentResult Invoke()
        {
            this.GetContents = this.connection.ImageResult.FromSqlRaw("LastSevRecords").ToList();
            return View(HtmlViewsPaths.homecontainer,this.GetContents);
        }
        public List<ImagePosition> GetContents 
        {
            get;
            set;
        }
    }
}
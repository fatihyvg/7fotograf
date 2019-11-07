using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _7fotograf.Interfaces;
using _7fotograf.Models;
using _7fotograf.Database;
using _7fotograf.ComponentPaths;
namespace _7fotograf.Components
{
    [ViewComponent(Name = "ımagegallery")]
    public class ListGallery : ViewComponent,IListContent<ImagePosition>
    {
        private Connection connection;
        public ListGallery(Connection connection)
        {
            this.connection = connection;
        }
        public IViewComponentResult Invoke()
        {
            this.GetContents = this.connection.ImageResult.FromSqlRaw("GetAllData").ToList();
            return View(HtmlViewsPaths.listgallery,this.GetContents);
        }
        public List<ImagePosition> GetContents
        {
            get;
            set;
        }
    }
}
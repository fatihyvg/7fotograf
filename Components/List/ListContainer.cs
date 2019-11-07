using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using _7fotograf.ComponentPaths;
using _7fotograf.Interfaces;
using _7fotograf.Database;
namespace _7fotograf.Components
{
    [ViewComponent(Name="listcontainer")]
    public class ListContainer : ViewComponent
    {
        ICategory category;
        Connection connection;
        public ListContainer(ICategory category,Connection connection)
        {
              this.category = category;
              this.connection = connection;
        }
        public IViewComponentResult Invoke()
        {
            this.category.CategoryList = this.connection.Category.FromSqlRaw("GetCategory").ToList();
            return View(HtmlViewsPaths.listcontainer,this.category.CategoryList);
        }
    }
}
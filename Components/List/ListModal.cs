using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _7fotograf.ComponentPaths;
using _7fotograf.Interfaces;
using _7fotograf.Database;
namespace _7fotograf.Components
{
    [ViewComponent(Name="listmodal")]
    public class ListModal : ViewComponent
    {
        ICategory category;
        Connection connection;
        public ListModal(ICategory category,Connection connection)
        {
            this.category = category;
            this.connection = connection;
        }
        public IViewComponentResult Invoke()
        {
            this.category.CategoryList = this.connection.Category.FromSqlRaw("GetCategory").ToList();
            return View(HtmlViewsPaths.listmodal,this.category.CategoryList);
        }
    }
}
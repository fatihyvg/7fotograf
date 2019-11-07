using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using _7fotograf.Interfaces;
using _7fotograf.Models;
using _7fotograf.Database;
using _7fotograf.ComponentPaths;
namespace _7fotograf.Components
{
    [ViewComponent(Name = "categorylist")]
    public class CategoryList : ViewComponent,ISqlParams,IListContent<Category>
    {
        Connection connection;
        public CategoryList(Connection connection)
        {
            this.connection = connection;
        }
        public IViewComponentResult Invoke()
        {
            this.GetContents = this.connection.Category.FromSqlRaw("GetCategory").ToList();
            return View(HtmlViewsPaths.categorylist,this.GetContents);
        }
        public SqlParameter SqlParam(string par,dynamic val)
        {
            try
            {
                return new SqlParameter(par,val);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<Category> GetContents
        {
            get;
            set;
        }
    }
}
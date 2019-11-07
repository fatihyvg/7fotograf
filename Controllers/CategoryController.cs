using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using _7fotograf.ComponentPaths;
using _7fotograf.Database;
using _7fotograf.Interfaces;
using _7fotograf.Models;
namespace _7fotograf.Controllers
{
    [Route("Category")]
    public class CategoryController : Controller,ISqlParams,IListContent<ImagePosition>
    {
        private Connection connection;
        public CategoryController(Connection connection)
        {
            this.connection = connection;
        }
        [Route("FetchList/{usercategory?}")]
        public ActionResult FetchList(string usercategory)
        {
            this.GetContents = this.connection.ImageResult.FromSqlRaw("EXECUTE dbo.ListOfByCategory @UserCategory",SqlParam("@UserCategory",usercategory)).ToList();
            return View(HtmlViewsPaths.category,this.GetContents);
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
        public List<ImagePosition> GetContents 
        {
            get;
            set;
        }
    }
}
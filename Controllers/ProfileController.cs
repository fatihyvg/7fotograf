using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using _7fotograf.ComponentPaths;
using _7fotograf.Interfaces;
using _7fotograf.Models;
using _7fotograf.Database;
namespace _7fotograf.Controllers
{
    [Route("Profile")]
    public class ProfileController : Controller,ISqlParams,IListContent<ImagePosition>
    {
        private readonly Connection connect;
        private readonly IImagePosition ımage;
        private readonly IDeleteImage delimage;
        public ProfileController(Connection connect,IImagePosition ımage,IDeleteImage delimage)
        {
            this.connect = connect; 
            this.ımage = ımage;
            this.delimage = delimage;
        }
        [Route("ProfileSettings/{userfbıd?}")]
        public ActionResult ProfileSettings(string userfbıd)
        {
            
            this.GetContents = this.connect.ImageResult.FromSqlRaw("EXECUTE dbo.GetProfileById @UserFbId",SqlParam("@UserFbId",userfbıd)).ToList();
            return View(HtmlViewsPaths.profile,this.GetContents);
        }
        [HttpPost]
        public JsonResult Update(int Id,IFormCollection col)
        {
            this.ımage.Id = Id;
            this.ımage.Story = col["updatestory"];
            this.connect.Database.ExecuteSqlRaw("dbo.Edit @Id,@Story",new [] {SqlParam("@Id",this.ımage.Id),SqlParam("@Story",this.ımage.Story)});
            return Json(this.ımage);
        }
        [HttpPost]
        [Route("DeleteImage/{Id?}")]
        public JsonResult DeleteImage(int Id)
        {
             this.ımage.Id = Id;
             List<DeleteImage> delim = this.connect.DeleteImages.FromSqlRaw("dbo.DeleteGetFileName @Id",SqlParam("@Id",this.ımage.Id)).ToList();
             foreach(var item in delim.ToArray())
             {
                  DeleteFolderFromImage(item.ImagePath);
                  this.connect.Database.ExecuteSqlRaw("dbo.DeleteImage @Id",SqlParam("@Id",item.Id));
             }
             return Json(this.ımage);
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
        private void DeleteFolderFromImage(string filename)
        {
             try
             {
                  string path = Path.Combine(Directory.GetCurrentDirectory(),filename);
                  if(System.IO.File.Exists(path))
                  {
                      System.IO.File.Delete(path);
                  }
                  else 
                  {
                      if(!System.IO.File.Exists(path) || string.IsNullOrEmpty(path) || path == null)
                      {
                          Exception excp = new Exception("Dosya Hatası Oluştu");
                          System.Console.WriteLine(excp.Message);
                      }
                  }
             }
             catch(FileNotFoundException ex)
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
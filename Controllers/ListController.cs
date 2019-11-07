using System;
using System.IO;
using System.Drawing;
using System.Collections;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using _7fotograf.ComponentPaths;
using _7fotograf.Interfaces;
using _7fotograf.Database;
using LazZiya.ImageResize;
using ExifLib;
namespace _7fotograf.Controllers
{
     public class ListController : Controller,ISqlParams
    {         

        private IImagePosition ımposition;
        private IFacebookLogin fblogin;
        private Connection connection;
        private ArrayList list;
        private string directorypath = "Contents/upload/";
        private string resımagepath;
        private Image ımager;
        public ListController(IImagePosition ımposition,IFacebookLogin fblogin,Connection connection)
        {
            this.ımposition = ımposition;
            this.connection = connection;
            this.fblogin = fblogin;
            list = new ArrayList();
        }
        public ActionResult login()
        {
             return View(HtmlViewsPaths.list);    
        }
       [HttpPost]
       public ActionResult ImageUpload(IFormFile file,IFormCollection col,string category)
       {
                 if(file != null)
                 {
                   if(!Directory.Exists(directorypath))
                   {
                         Directory.CreateDirectory(directorypath);
                   }
                   if(Path.GetExtension(file.FileName) == ".jpg" || Path.GetExtension(file.FileName) == ".JPG")
                   {
                         if(!string.IsNullOrEmpty(category))
                          {
                           if(file.Length > 0)
                           {
                               ımager = Image.FromStream(file.OpenReadStream());
                               var exifinfo = ExifReader.ReadJpeg(file.OpenReadStream()); 
                               this.ımposition.ExifFNumber = Convert.ToString(exifinfo.FNumber);
                               this.ımposition.ExifExposureTime = Convert.ToString(exifinfo.ExposureTime);
                               this.ımposition.Make = exifinfo.Make; 
                               this.ımposition.Model = exifinfo.Model;
                               this.ımposition.Dates = exifinfo.DateTime;              
                               var img = ImageResize.Scale(ımager,1296,864);
                               string filename = Path.GetFileName(file.FileName);
                               img.SaveAs($"Contents\\upload\\{category}\\{filename}");
                               string added = category+"/"+filename;
                               resımagepath = Path.Combine(directorypath,Convert.ToString(added)).Replace(@"\","/");
                           }
                        }
                     }
                     
                     this.fblogin.UserFbId = col["fbıd"];
                     this.fblogin.UserName = col["fbname"];
                     this.fblogin.UserEmail = col["fbemail"];
                     this.ımposition.UserCategory = col["category"];
                     this.ımposition.Approval = Convert.ToInt32(col["app"]);
                     this.ımposition.ImagePath = resımagepath;
                     this.ımposition.Story = col["story"];

                     list.Add (
                          new ArrayList {
                                this.fblogin.UserFbId,
                                this.fblogin.UserName,
                                this.fblogin.UserEmail,
                                this.ımposition.UserCategory,
                                this.ımposition.ImagePath,
                                this.ımposition.Story,
                                this.ımposition.Approval,
                                this.ımposition.ExifFNumber,
                                this.ımposition.ExifExposureTime,
                                this.ımposition.Make,
                                this.ımposition.Model,
                                this.ımposition.Dates
                          }
                       );
                      try 
                      {
                      this.connection.Database.ExecuteSqlRaw("AddImages @UserFbId,@UserName,@UserEmail,@UserCategory,@ImagePath,@Story,@Approval,@ExifExposureTime,@ExifFNumber,@Make,@Model,@Dates",new[] {
                      SqlParam("@UserFbId",this.fblogin.UserFbId),
                      SqlParam("@UserName",this.fblogin.UserName),
                      SqlParam("@UserEmail",this.fblogin.UserEmail),
                      SqlParam("@UserCategory",this.ımposition.UserCategory),
                      SqlParam("@ImagePath",this.ımposition.ImagePath),
                      SqlParam("@Story",this.ımposition.Story),
                      SqlParam("@Approval",this.ımposition.Approval),
                      SqlParam("@ExifExposureTime",this.ımposition.ExifExposureTime),
                      SqlParam("@ExifFNumber",this.ımposition.ExifFNumber),
                      SqlParam("@Make",this.ımposition.Make),
                      SqlParam("@Model",this.ımposition.Model),
                      SqlParam("@Dates",this.ımposition.Dates)
                     });
                   }catch(SqlException ex)
                   {
                       throw ex;
                   }

                 } 
             return Json(this.list);
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
    }
}
using System;
namespace _7fotograf.Interfaces
{
    public interface IImagePosition : IFacebookLogin
    {
         int Id 
         {
             get;
             set;
         }
         int Approval 
         {
             get;
             set;
         }
         string UserCategory 
         {
             get;
             set;
         }
         string Story 
         {
             get;
             set;
         }
         string ImagePath 
         {
             get;
             set;
         }
         string Dates
         {
             get;
             set;
         }
         string Model
         {
             get;
             set;
         }
         string Make
         {
             get;
             set;
         }
         string ExifExposureTime 
         {
             get;
             set;
         }
         string ExifFNumber 
         {
             get;
             set;
         }
        new string UserFbId 
         {
             get;
             set;
         }
        new string UserName 
         {
             get;
             set;
         }
        new string UserEmail 
         {
             get;
             set;
         }

    }
}
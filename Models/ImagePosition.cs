using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _7fotograf.Interfaces;
namespace _7fotograf.Models
{
    public class ImagePosition : IImagePosition
    {
        [Key]
        public int Id 
        {
            get;
            set;
        }
        [NotMapped]
        public int Approval 
        {
            get;
            set;
        }
        public string UserCategory 
        {
            get;
            set;
        }
        public string UserFbId 
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public string UserEmail 
        {
            get;
            set;
        }
        public string Story 
        {
            get;
            set;
        }
        public string ImagePath 
        {
            get;
            set;
        }
        public string Dates 
        {
            get;
            set;
        }
        public string Model 
        {
            get;
            set;
        }
        public string Make 
        {
            get;
            set;
        }
        public string ExifExposureTime 
        {
            get;
            set;
        }
        public string ExifFNumber 
        {
            get;
            set;
        }
    }
}
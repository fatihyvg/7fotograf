using System.ComponentModel.DataAnnotations;
using _7fotograf.Interfaces;
namespace _7fotograf.Models
{
    public class DeleteImage : IDeleteImage
    {
        [Key]
        public int Id 
        {
            get;
            set;
        }
        public string ImagePath 
        {
            get;
            set;
        }
    }
}
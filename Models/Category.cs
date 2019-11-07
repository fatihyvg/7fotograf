using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _7fotograf.Interfaces;
namespace _7fotograf.Models
{
    public class Category : ICategory
    {
        [Key]
        public int CategoryId
        {
            get;
            set;
        }
        public string CategoryName 
        {
            get;
            set;
        }
        [NotMapped]
        public bool IsChecked 
        {
            get;
            set;
        }
        [NotMapped]
        public List<Category> CategoryList
        {
            get;
            set;
        }
    }
}
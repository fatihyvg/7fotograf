using System.Collections.Generic;
using _7fotograf.Models;
namespace _7fotograf.Interfaces
{
    public interface ICategory
    {
         int CategoryId 
         {
             get;
             set;
         }
         string CategoryName
         {
             get;
             set;
         }
         bool IsChecked 
         {
             get;
             set;
         }
         List<Category> CategoryList
         {
             get;
             set;
         }
    }
}
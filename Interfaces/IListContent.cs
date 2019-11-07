using System.Collections.Generic;
namespace _7fotograf.Interfaces
{
    public interface IListContent<T>
    {
         List<T> GetContents
         {
             get;
             set;
         }
    }
}
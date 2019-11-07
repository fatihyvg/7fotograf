using Microsoft.Data.SqlClient;
namespace _7fotograf.Interfaces
{
    public interface ISqlParams
    {
         SqlParameter SqlParam(string par,dynamic val);
    }
}
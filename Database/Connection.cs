using Microsoft.EntityFrameworkCore;
using _7fotograf.Models;
namespace _7fotograf.Database
{
    public class Connection : DbContext
    {
        public Connection(DbContextOptions<Connection> options) : base(options)
        {

        }
        public DbSet<Category> Category 
        {
            get;
            set;
        }
        public DbSet<ImagePosition> ImageResult
        {
            get;
            set;
        }
        public DbSet<DeleteImage> DeleteImages
        {
            get;
            set;
        }
    }
}
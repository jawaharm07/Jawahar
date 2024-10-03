using ApiG.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiG.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> opt) : base(opt)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}

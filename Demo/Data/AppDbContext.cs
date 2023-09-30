using Demo.Entites;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        //---------------[ Set Here ]----------------
        public DbSet<Student> Student { get; set; }
        //-------------------------------------------
    }
}

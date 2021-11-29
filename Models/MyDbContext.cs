using Microsoft.EntityFrameworkCore;

namespace ProjetoDeAnalise.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<user> user { get; set; }
    }
}
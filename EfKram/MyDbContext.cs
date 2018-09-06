using System.Net.WebSockets;
using Microsoft.EntityFrameworkCore;

namespace EfKram
{
    public class MyDbContext : DbContext, IMyDbContext
    {
        public DbSet<TestObject> TestObjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("");
            base.OnConfiguring(optionsBuilder);
        }
    }
};
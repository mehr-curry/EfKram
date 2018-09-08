using System.Net.WebSockets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace EfKram
{
    public class MyDbContext : DbContext, IMyDbContext
    {
        public DbSet<TestObject> TestObjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("server=172.17.0.2;initial catalog=MyDbContext;User=sa;password=1234@abcd");
            base.OnConfiguring(optionsBuilder);
        }
    }
};
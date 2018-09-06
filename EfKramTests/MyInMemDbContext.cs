using EfKram;
using Microsoft.EntityFrameworkCore;

namespace EfKramTests
{
    public class MyInMemDbContext : DbContext, IMyDbContext
    {
        public DbSet<TestObject> TestObjects { get; set; }
    }
}
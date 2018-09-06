using Microsoft.EntityFrameworkCore;

namespace EfKram
{
    public interface IMyDbContext : IPublicDbContext
    {
        DbSet<TestObject> TestObjects { get; set; }
    }
}
using System;
using System.Linq;
using EfKram;
using Microsoft.EntityFrameworkCore;

namespace EfKramHost
{
    public class Class1
    {
        static void Main()
        {
            var context = new MyDbContext();
            context.Database.Migrate();    
            var result = context.TestObjects.Count();
        }
    }
}
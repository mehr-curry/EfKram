using System;
using System.Linq;
using EfKram;
using Xunit;

namespace EfKramTests
{
    public class EfKramTests : IClassFixture<CompositionFixture>
    {
        public EfKramTests(CompositionFixture fixture)
        {
            Fixture = fixture;
        }

        public CompositionFixture Fixture { get; set; }

        [Fact]
        public void Test1()
        {
            var context = Fixture.Host.GetExport<IMyDbContext>();
            var obj = new TestObject();
            context.Add(obj);
            context.SaveChanges();
            
            Assert.True(context.TestObjects.Count() == 1);
        }
    }
}
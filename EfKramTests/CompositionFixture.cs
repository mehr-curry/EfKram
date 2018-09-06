using System;
using System.Composition.Convention;
using System.Composition.Hosting;
using System.Transactions;
using EfKram;

namespace EfKramTests
{
    public class CompositionFixture : IDisposable
    {
        public ConventionBuilder Registration { get; set; }
        public CompositionHost Host { get; set; }
        public CompositionFixture()
        {
            Registration = new ConventionBuilder();
            Registration.ForTypesDerivedFrom<IMyDbContext>().Export<MyInMemDbContext>();
            Host = new ContainerConfiguration().WithAssembly(this.GetType().Assembly,Registration).CreateContainer();
        }
        public void Dispose()
        {
            
        }
    }
}
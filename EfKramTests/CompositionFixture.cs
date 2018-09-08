using System;
using System.Composition.Convention;
using System.Composition.Hosting;
using System.Transactions;
using EfKram;

namespace EfKramTests
{
    public class CompositionFixture : IDisposable
    {
        public ConventionBuilder Registration { get; private set; }
        
        public CompositionHost Host { get; private set; }
        
        public CompositionFixture()
        {
            Registration = new ConventionBuilder();
            Registration.ForTypesDerivedFrom<IMyDbContext>().Export<IMyDbContext>();
            Host = new ContainerConfiguration().WithAssembly(this.GetType().Assembly,Registration).CreateContainer();
        }
        
        public void Dispose()
        {
            
        }
    }
}
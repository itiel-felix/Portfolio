using System.Runtime.CompilerServices;

namespace LandingPage.Services
{
    public class SingletonService
    {
        public SingletonService()
        {
            getGuid = Guid.NewGuid();
        }
        public Guid getGuid { get; private set; }
    }
    public class DelimitedService
    {
        public DelimitedService()
        {
            getGuid = Guid.NewGuid();
        }
        public Guid getGuid { get; private set; }
    }
    public class TranseuntService
    {
        public TranseuntService()
        {
            getGuid = Guid.NewGuid();
        }
        public Guid getGuid { get; private set; }
    }
}

using Dependency_Injection.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Dependency_Injection
{
    public class KonteynerOrnek
    {
        public KonteynerOrnek()
        {
            IServiceCollection services = new ServiceCollection();
            // IServiceCollection .Net mimarisinde built-in gelen IoC yapılanmasını barındıran türdür.
            services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog()));
            services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));
            // yeni bir servis eklerken de türünü belirtip örnekleyerek bu şekilde ekliyoruz

           ServiceProvider provider = services.BuildServiceProvider(); // burda konteynerimizi inşa ettik
            provider.GetService<ConsoleLog>(); // bu şekilde de getiriyoruz eklediğimiz şeyleri.

            // startuptaki ConfigureServicesde verdiğimiz tüm değerler mimarimizde oluşturulacak konteynera dahil ediliyor ve uygulama çalıştığında konteyner ayağa kalkıyor.
            // bu sayede istediğimiz controllerda direk konteyner üzerinden bir şeyler çağırabiliyoruz.
            // --> Startup.cs'e git
        }
    }
}

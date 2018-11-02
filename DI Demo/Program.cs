using System;
using Microsoft.Extensions.DependencyInjection;

namespace DI_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ConfigureDependencies();

            var hello = serviceProvider.GetService<IFoo>();

            Hello hello2 = new Hello();

            Console.WriteLine(hello.AddSomething(4, 9));
            Console.WriteLine(hello2.DivideSomething(9, 3));

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        static ServiceProvider ConfigureDependencies()
        {
            var serviceProvider = new ServiceCollection()
                            .AddSingleton<IFoo, Hello>()
                            .BuildServiceProvider();

            return serviceProvider;
        }
    }
}

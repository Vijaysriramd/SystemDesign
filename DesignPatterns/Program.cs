using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Design Patterns Demo ===\n");
            Console.WriteLine("Starting application...");

            // Adapter Pattern
            Console.WriteLine("1. Adapter Pattern:");
            DesignPatterns.Adapter.Client.Demo();
            Console.WriteLine();

            // Bridge Pattern
            Console.WriteLine("2. Bridge Pattern:");
            DesignPatterns.Bridge.Client.Demo();
            Console.WriteLine();

            // Builder Pattern
            Console.WriteLine("3. Builder Pattern:");
            DesignPatterns.Builder.Client.Demo();
            Console.WriteLine();

            // Singleton Pattern
            Console.WriteLine("4. Singleton Pattern:");
            DesignPatterns.Singleton.Client.Demo();
            Console.WriteLine();

            // Decorator Pattern
            Console.WriteLine("5. Decorator Pattern:");
            DesignPatterns.Decorator.Client.Demo();
            Console.WriteLine();

            // Abstract Factory Pattern
            Console.WriteLine("6. Abstract Factory Pattern:");
            DesignPatterns.Factory.AbstractFactory.Client.Demo();
            Console.WriteLine();

            // Practical Factory Pattern
            Console.WriteLine("7. Practical Factory Pattern:");
            DesignPatterns.Factory.PracticalFactory.Client.Demo();
            Console.WriteLine();

            // Flyweight Pattern
            Console.WriteLine("8. Flyweight Pattern:");
            DesignPatterns.Flyweight.Client.Demo();
            Console.WriteLine();

            // Prototype Pattern
            Console.WriteLine("9. Prototype Pattern:");
            DesignPatterns.Prototype.Client.Demo();
            Console.WriteLine();

            // Observer Pattern
            Console.WriteLine("10. Observer Pattern:");
            DesignPatterns.Observer.Client.Demo();
            Console.WriteLine();

            // Strategy Pattern
            Console.WriteLine("11. Strategy Pattern:");
            DesignPatterns.Strategy.Client.Demo();
            Console.WriteLine();

            // Chain of Responsibility Pattern
            Console.WriteLine("12. Chain of Responsibility Pattern:");
            DesignPatterns.ChainOfResponsibility.Client.Demo();
            Console.WriteLine();

            Console.WriteLine("=== All Design Patterns Demo Completed ===");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

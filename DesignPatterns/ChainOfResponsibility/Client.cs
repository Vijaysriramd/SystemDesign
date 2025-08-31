using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Client
    {
        public static void Demo()
        {
            Console.WriteLine("=== Chain of Responsibility Pattern Demo ===");

            var level1 = new Level1Support();
            var level2 = new Level2Support();
            var level3 = new Level3Support();

            // Build the chain
            level1.SetNext(level2).SetNext(level3);

            // Test different request levels
            Console.WriteLine("Testing request level 5:");
            level1.Handle(5);

            Console.WriteLine("\nTesting request level 25:");
            level1.Handle(25);

            Console.WriteLine("\nTesting request level 75:");
            level1.Handle(75);

            Console.WriteLine("\nTesting request level 150:");
            level1.Handle(150);
        }
    }
}


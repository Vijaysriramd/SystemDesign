using System;

namespace DesignPatterns.Decorator
{
    public class Client
    {
        public static void Demo()
        {
            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine($"Cost: ${coffee.GetCost()}; Description: {coffee.GetDescription()}");

            ICoffee milkCoffee = new MilkDecorator(coffee);
            Console.WriteLine($"Cost: ${milkCoffee.GetCost()}; Description: {milkCoffee.GetDescription()}");

            ICoffee milkSugarCoffee = new SugarDecorator(milkCoffee);
            Console.WriteLine($"Cost: ${milkSugarCoffee.GetCost()}; Description: {milkSugarCoffee.GetDescription()}");
        }
    }
}

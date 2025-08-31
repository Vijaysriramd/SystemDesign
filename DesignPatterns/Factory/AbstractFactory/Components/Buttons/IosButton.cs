using System;

namespace DesignPatterns.Factory.AbstractFactory.Components.Buttons
{
    public class IosButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Hello, I am iOS Button");
        }
    }
}

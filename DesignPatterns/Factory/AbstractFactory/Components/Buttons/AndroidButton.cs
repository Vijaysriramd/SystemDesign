using System;

namespace DesignPatterns.Factory.AbstractFactory.Components.Buttons
{
    public class AndroidButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Hello, I am Android Button");
        }
    }
}

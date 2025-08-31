using System;

namespace DesignPatterns.Factory.AbstractFactory.Components.Dropdowns
{
    public class IosDropdown : IDropdown
    {
        public void Paint()
        {
            Console.WriteLine("Hello, I am iOS Dropdown");
        }
    }
}

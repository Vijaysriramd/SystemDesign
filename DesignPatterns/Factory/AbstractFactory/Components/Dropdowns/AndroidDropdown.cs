using System;

namespace DesignPatterns.Factory.AbstractFactory.Components.Dropdowns
{
    public class AndroidDropdown : IDropdown
    {
        public void Paint()
        {
            Console.WriteLine("Hello, I am Android Dropdown");
        }
    }
}

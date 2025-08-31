using System;

namespace DesignPatterns.Factory.PracticalFactory
{
    public class Car : IVehicle
    {
        public void Build()
        {
            Console.WriteLine("Building a Car!");
        }
    }
}

using System;

namespace DesignPatterns.Factory.PracticalFactory
{
    public class Motorcycle : IVehicle
    {
        public void Build()
        {
            Console.WriteLine("Building a Motorcycle!");
        }
    }
}

using System;

namespace DesignPatterns.Factory.PracticalFactory
{
    public class Client
    {
        public static void Demo()
        {
            VehicleFactory carFactory = new CarVehicleFactory();
            var car = carFactory.BuildVehicle();

            VehicleFactory motorcycleFactory = new MotorcycleVehicleFactory();
            var motorcycle = motorcycleFactory.BuildVehicle();
        }
    }
}

namespace DesignPatterns.Factory.PracticalFactory
{
    public class CarVehicleFactory : VehicleFactory
    {
        protected override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}

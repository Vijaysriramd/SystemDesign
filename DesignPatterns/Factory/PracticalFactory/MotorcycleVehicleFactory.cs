namespace DesignPatterns.Factory.PracticalFactory
{
    public class MotorcycleVehicleFactory : VehicleFactory
    {
        protected override IVehicle CreateVehicle()
        {
            return new Motorcycle();
        }
    }
}

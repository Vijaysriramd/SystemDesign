namespace DesignPatterns.Factory.PracticalFactory
{
    public abstract class VehicleFactory
    {
        public IVehicle BuildVehicle()
        {
            IVehicle vehicle = CreateVehicle();
            vehicle.Build();
            return vehicle;
        }

        protected abstract IVehicle CreateVehicle();
    }
}

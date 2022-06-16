using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    abstract class VehicleDecorator : Vehicle //Decorator Base//
    {
        Vehicle Vehicle = null;
        public VehicleDecorator(Vehicle vehicle)
        {
            this.Vehicle = vehicle;
        }
        public override string GetCarrierCapabilities()
        {
            return Vehicle.GetCarrierCapabilities();
        }
        public override string GetEngineSize()
        {
            return Vehicle.GetEngineSize();
        }
        public override string GetTowing()
        {
            return Vehicle.GetTowing();
        }
    }
}

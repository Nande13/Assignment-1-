using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    abstract class VehicleDecorator : Vehicle //Decorator Base//
    {
        Vehicle Vehicle = null;
        public VehicleDecorator(Vehicle vehicle): base(vehicle)
        {
            this.Vehicle = vehicle;
        }
        public override string GetVehicleDescription()
        {
            return Vehicle.GetVehicleDescription();
        }
        public override string GetWifi()
        {
            return Vehicle.GetWifi();
        }
        public override string GetSoundSystem()
        {
            return Vehicle.GetSoundSystem();
        }
        public override string GetCamera()
        {
            return Vehicle.GetCamera();
        }
    }
}

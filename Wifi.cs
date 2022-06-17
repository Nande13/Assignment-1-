using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Wifi:VehicleDecorator
    {
        Vehicle Vehicle = null;
        public Wifi(Vehicle vehicle) : base(vehicle)
        {
            this.Vehicle = vehicle;
        }
        public override string GetWifi()
        {
            return "Wifi";
        }
    }
}

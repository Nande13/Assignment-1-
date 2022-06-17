using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Camera:VehicleDecorator
    {
        Vehicle Vehicle = null;
        public Camera(Vehicle vehicle) : base(vehicle)
        {
            this.Vehicle = vehicle;
        }
        public override string GetCamera()
        {
            return "Camera";
        }
    }
}

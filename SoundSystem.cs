using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class SoundSystem:VehicleDecorator
    {
        Vehicle Vehicle = null;
        public SoundSystem(Vehicle vehicle) : base(vehicle)
        {
            this.Vehicle = vehicle;
        }
        public override string GetSoundSystem()
        {
            return "SoundSystem";
        }
    }
}

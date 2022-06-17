using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class LightVehicle : Vehicle //Concrete Component//
    {
        public LightVehicle(Engine engine, Carrier carrier, Towing towing) : base(engine, carrier, towing)
        {
            this.Carrier = carrier;
            this.Engine = engine;
            this.Towing = towing;
        }
        public override string GetVehicleDescription()
        {
            return "Heavy Vehicle";
        }
        public override string GetWifi()
        {
            return "No Wifi";
        }
        public override string GetSoundSystem()
        {
            return "No SoundSystem";
        }
        public override string GetCamera()
        {
            return "No Camera";
        }
    }
    
}

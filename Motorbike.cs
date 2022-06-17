using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Motorbike : Vehicle //concreteComponent//
    {
        //Strategy Pattern
        public Motorbike(Engine engine, Carrier carrier, Towing towing) : base(engine, carrier, towing)
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

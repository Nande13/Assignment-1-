using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class HeavyVehicle : Vehicle  //Concrete component//
    {
        //public HeavyVehicle(double Wifi, double SoundSystem, double Camera/*, double price*/):base (Wifi, SoundSystem, Camera/*, price*/)
        //{
        //    wifi = Wifi;
        //    soundSystem = SoundSystem;
        //    camera = Camera;
        //}
        //public override string GetName()
        //{
        //    return "Heavy vehicle";
        //}
        //public override string GetCarrierCapabilities()
        //{
        //    return "20 people and above";
        //}
        //public override string GetEngineSize()
        //{
        //    return "Large";
        //}
        //public override string GetTowing()
        //{
        //    return "Yes";
        //}
        //public override double ExtraFeatures()
        //{
        //    private double wifi;
        //    private double soundSystem;
        //    private double camera;
        //    private List<>
        //}


        public HeavyVehicle(Engine engine, Carrier carrier, Towing towing) : base(engine, carrier, towing)
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

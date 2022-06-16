using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    abstract class Vehicle //ComponentBase//
    {
        private double wifi;
        public double soundSystem;
        public double camera;
        private List<IVehicleType> vehicleTypes = new List<IVehicleType>();

        public abstract string GetName();
        public abstract string GetCarrierCapabilities();
        public abstract string GetEngineSize();
        public abstract string GetTowing();
        public abstract double ExtraFeatures();
        public Vehicle(double wifi, double soundSystem, double camera, double price)
        {
            this.wifi = wifi;
            this.soundSystem = soundSystem;
            this.camera = camera;
        }
       
        public void Attach(IVehicleType vehicleType)
        {
            vehicleTypes.Add(vehicleType);
        }

        public void Detach(IVehicleType vehicleType)
        {
            vehicleTypes.Remove(vehicleType);
        }

        public void Notify()
        {
            foreach (IVehicleType vehicleType in vehicleTypes)
            {
                vehicleType.Update(this);
            }
            Console.WriteLine("");
        }

        public double Wifi
        {
            get { return wifi; }
            set
            {
                if (wifi != value)
                {
                    wifi = value;
                    Notify();
                }
            }
        }

        public double SoundSystem
        {
            get { return soundSystem; }
            set
            {
                if (soundSystem != value)
                {
                    soundSystem = value;
                    Notify();
                }
            }
        }

        public double Camera
        {
            get { return camera; }
            set
            {
                if (camera != value)
                {
                    camera = value;
                    Notify();
                }
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    abstract class Vehicle:ISubject //ComponentBase//
    {
        //public double wifi;
        //public double soundSystem;
        //public double camera;
        //private List<IVehicleType> vehicleTypes = new List<IVehicleType>();

        //public abstract string GetName();
        //public abstract string GetCarrierCapabilities();
        //public abstract string GetEngineSize();
        //public abstract string GetTowing();
        ////public abstract double ExtraFeatures();
        //public Vehicle(double wifi, double soundSystem, double camera/*, double price*/)
        //{
        //    this.wifi = wifi;
        //    this.soundSystem = soundSystem;
        //    this.camera = camera;
        //}

        //public Vehicle(Vehicle vehicle)
        //{

        //}

        //public void Attach(IVehicleType vehicleType)
        //{
        //    vehicleTypes.Add(vehicleType);
        //}

        //public void Detach(IVehicleType vehicleType)
        //{
        //    vehicleTypes.Remove(vehicleType);
        //}

        //public void Notify()
        //{
        //    foreach (IVehicleType vehicleType in vehicleTypes)
        //    {
        //        vehicleType.Update(this);
        //    }
        //    Console.WriteLine("");
        //}

        //public double Wifi
        //{
        //    get { return wifi; }
        //    set
        //    {
        //        if (wifi != value)
        //        {
        //            wifi = value;
        //            Notify();
        //        }
        //    }
        //}

        //public double SoundSystem
        //{
        //    get { return soundSystem; }
        //    set
        //    {
        //        if (soundSystem != value)
        //        {
        //            soundSystem = value;
        //            Notify();
        //        }
        //    }
        //}

        //public double Camera
        //{
        //    get { return camera; }
        //    set
        //    {
        //        if (camera != value)
        //        {
        //            camera = value;
        //            Notify();
        //        }
        //    }
        //}

        //DECORATOR
        public Vehicle(Vehicle vehicle)
        {

        }
        public abstract string GetVehicleDescription();
        public abstract string GetWifi();
        public abstract string GetSoundSystem();
        public abstract string GetCamera();

        //OBSERVER
        public List<IObserver> Technicians = new List<IObserver>();
        public void Attach(IObserver Target)
        {
            Technicians.Add(Target);
        }
        public void Detach(IObserver Target)
        {
            Technicians.Remove(Target);
        }
        public void Notify()
        {
            foreach (IObserver technician in Technicians)
                technician.Update();
        }
        //STRATEGY
        public Carrier Carrier { get; set; }
        public Engine Engine { get; set; }
        public Towing Towing { get; set; }
        public Vehicle(Engine engine, Carrier carrier, Towing towing)
        {
            this.Engine = engine;
            this.Carrier = carrier;
            this.Towing = towing;
        }
        public void Capabilities()
        {
            Console.WriteLine("Engine: " + Engine.GetEngine());
            Console.WriteLine("Carrier capabilities: " + Carrier.GetCarrier());
            Console.WriteLine("Towing capabilities: " + Towing.GetTowing());
        }

    }
}

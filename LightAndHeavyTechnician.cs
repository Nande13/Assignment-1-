using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class LightAndHeavyTechnician : IObserver //ConcreteObserver
    {
        public string TechnicianDescription = "Light & Heavy Vehicle Technician";
        Vehicle vehicle;

        public LightAndHeavyTechnician(Vehicle vehicle)
        {
            this.vehicle = vehicle;
            this.vehicle.Attach(this);
        }
        public void Update()
        {
            string wifi = vehicle.GetWifi();
            string soundSystem = vehicle.GetSoundSystem();
            string camera = vehicle.GetCamera();

            Console.WriteLine($"Worked on by a {TechnicianDescription}:");

            int wifiPrice = 1000;
            int soundSystemPrice = 1400;
            int CameraPrice = 600;
            if(vehicle.GetVehicleDescription() == "Light Vehicle")
            {
                wifiPrice = 950;
                soundSystemPrice = 1200;
                CameraPrice = 400;
            }
            if (wifi != "No Wifi")
            {
                Console.WriteLine("Wifi installed for R" + wifiPrice);
            }
            if (wifi != "No Sound System")
            {
                Console.WriteLine("Sound System installed for R" + soundSystemPrice);
            }
            if (wifi != "No Camera")
            {
                Console.WriteLine("Camera installed for R" + CameraPrice);
            }
        }
    }
}

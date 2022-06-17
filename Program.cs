using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle vehicle = new Motorbike();
            //Console.WriteLine(vehicle.GetVehicleDescription());
            //Console.WriteLine("Carrier capabilities: " + vehicle.GetCarrier() + ";" + " " + "Engine size: " + vehicle.GetEngine() + ";" + " " + "Towing capability: "  + " " + vehicle.GetTowing());

            //Console.WriteLine();

            //Vehicle vehicle1 = new LightVehicle();
            //Console.WriteLine(vehicle1.GetName());
            //Console.WriteLine("Carrier capabilities: " + vehicle1.GetCarrierCapabilities() + ";" + " " + "Engine size: " + vehicle1.GetEngineSize() + ";" + " " + "Towing capability: "  + " " + vehicle1.GetTowing());

            //Console.WriteLine();

            Vehicle vehicle2 = new HeavyVehicle(new Small(), new GoodAndDriver(), new CanTow());
            Console.WriteLine(vehicle2.GetVehicleDescription());
            vehicle2.Capabilities();
            vehicle2 = new Wifi(vehicle2);
            vehicle2 = new SoundSystem(vehicle2);
            vehicle2 = new Camera(vehicle2);

            IObserver technician = new LightAndHeavyTechnician(vehicle2);
            vehicle2.Notify();

            Console.ReadLine();
        }
    }
}

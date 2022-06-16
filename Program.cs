using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Motorbike();
            Console.WriteLine(vehicle.GetName());
            Console.WriteLine("Carrier capabilities: " + vehicle.GetCarrierCapabilities() + ";" + " " + "Engine size: " + vehicle.GetEngineSize() + ";" + " " + "Towing capability: "  + " " + vehicle.GetTowing());

            Console.WriteLine();

            Vehicle vehicle1 = new LightVehicle();
            Console.WriteLine(vehicle1.GetName());
            Console.WriteLine("Carrier capabilities: " + vehicle1.GetCarrierCapabilities() + ";" + " " + "Engine size: " + vehicle1.GetEngineSize() + ";" + " " + "Towing capability: "  + " " + vehicle1.GetTowing());

            Console.WriteLine();

            Vehicle vehicle2 = new HeavyVehicle();
            Console.WriteLine(vehicle2.GetName());
            Console.WriteLine("Carrier capabilities: " + vehicle2.GetCarrierCapabilities() + ";" + " " + "Engine size: " + vehicle2.GetEngineSize() + ";" + " " + "Towing capability: "  + " " + vehicle2.GetTowing());

            Console.ReadLine();
        }
    }
}

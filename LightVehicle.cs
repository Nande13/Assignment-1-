using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class LightVehicle : Vehicle //Concrete Component//
    {
        public override string GetName()
        {
            return "Light vehicle";
        }
        public override string GetCarrierCapabilities()
        {
            return "2 people max and luggage"; 
        }
        public override string GetEngineSize()
        {
            return "Medium";
        }
        public override string GetTowing()
        {
            return "No";
        }
    }
    
}

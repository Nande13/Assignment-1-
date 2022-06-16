using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Motorbike : Vehicle //concreteComponent//
    {
        public override string GetName()
        {
            return "Motobike";
        }
        public override string GetCarrierCapabilities()
        {
            return "Good and Driver";
        }
        public override string GetEngineSize()
        {
            return "Small";
        }
        public override string GetTowing()
        {
            return "No";
        }

    }
}

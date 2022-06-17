using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class CannotTow:Towing
    {
        public override string GetTowing()
        {
            return "Cannot Tow";
        }
    }
}

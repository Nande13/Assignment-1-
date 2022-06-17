using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal interface ISubject
    {
        void Attach(IObserver Target);
        void Detach(IObserver Target);
        void Notify();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePage273
{
    class MySubclass : MyBaseClass
    {
        public MySubclass(string baseClassNeedsThis, int anotherValue)
            :base(baseClassNeedsThis)
        {
            Console.WriteLine("This is the subclass: " + baseClassNeedsThis + " and " + anotherValue);
        }
    }
}

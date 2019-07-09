using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePage300 {
    interface IClown {
        string FunnyThingIHave { get; }
        void Honk();
    }

    interface IScaryClown : IClown {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}

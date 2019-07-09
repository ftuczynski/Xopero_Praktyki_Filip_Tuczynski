using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPage332 {
    class OutsideWithDoor : Outside, IHasExteriorDoor {
        public string DoorDescription { get; }
        public Location DoorLocation { get; }

        public OutsideWithDoor(string name, bool hot, string doorDescription)
            : base(name, hot) {
            this.DoorDescription = doorDescription;
        }
    }
}
